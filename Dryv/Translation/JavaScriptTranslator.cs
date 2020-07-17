﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Dryv.Configuration;
using Dryv.Extensions;
using Dryv.Reflection;
using Dryv.Translation.Visitors;

namespace Dryv.Translation
{
    public class JavaScriptTranslator : Translator
    {
        private static readonly MethodInfo DryvValidationResultImplicitConvert = typeof(DryvValidationResult).GetMethod("op_Implicit");

        private static readonly Dictionary<ExpressionType, string> Terminals = new Dictionary<ExpressionType, string>
        {
            //[ExpressionType.ArrayIndex] = "",
            //[ExpressionType.ArrayLength] = "",
            //[ExpressionType.Block] = "",
            //[ExpressionType.Call] = "",
            //[ExpressionType.Constant] = "",
            //[ExpressionType.Convert] = "",
            //[ExpressionType.ConvertChecked] = "",
            //[ExpressionType.DebugInfo] = "",
            //[ExpressionType.Default] = "",
            //[ExpressionType.Dynamic] = "",
            //[ExpressionType.Extension] = "",
            //[ExpressionType.Goto] = "",
            //[ExpressionType.Index] = "",
            //[ExpressionType.Invoke] = "",
            //[ExpressionType.Label] = "",
            //[ExpressionType.Lambda] = "",
            //[ExpressionType.ListInit] = "",
            //[ExpressionType.Loop] = "",
            //[ExpressionType.MemberAccess] = "",
            //[ExpressionType.MemberInit] = "",
            //[ExpressionType.New] = "",
            //[ExpressionType.NewArrayBounds] = "",
            //[ExpressionType.NewArrayInit] = "",
            //[ExpressionType.OnesComplement] = "",
            //[ExpressionType.Parameter] = "",
            //[ExpressionType.RuntimeVariables] = "",
            //[ExpressionType.Switch] = "",
            //[ExpressionType.Throw] = "throw",
            //[ExpressionType.Try] = "",
            //[ExpressionType.TypeAs] = "",
            //[ExpressionType.TypeEqual] = "",
            //[ExpressionType.Unbox] = "",
            [ExpressionType.Add] = "+",
            [ExpressionType.AddAssign] = "+=",
            [ExpressionType.AddAssignChecked] = "+=",
            [ExpressionType.AddChecked] = "+",
            [ExpressionType.And] = "&&",
            [ExpressionType.AndAlso] = "&&",
            [ExpressionType.AndAssign] = "&=",
            [ExpressionType.Assign] = "=",
            [ExpressionType.Coalesce] = "||",
            //[ExpressionType.Conditional] = "",
            [ExpressionType.Decrement] = "--",
            [ExpressionType.Divide] = "/",
            [ExpressionType.DivideAssign] = "/=",
            [ExpressionType.Equal] = "===",
            [ExpressionType.ExclusiveOr] = "||",
            [ExpressionType.ExclusiveOrAssign] = "|=",
            [ExpressionType.GreaterThan] = ">",
            [ExpressionType.GreaterThanOrEqual] = ">=",
            [ExpressionType.Increment] = "++",
            [ExpressionType.IsFalse] = "!== false",
            [ExpressionType.IsTrue] = "!== true",
            [ExpressionType.LeftShift] = "<<",
            [ExpressionType.LeftShiftAssign] = "<<=",
            [ExpressionType.LessThan] = "<",
            [ExpressionType.LessThanOrEqual] = "<=",
            [ExpressionType.Modulo] = "%",
            [ExpressionType.ModuloAssign] = "%=",
            [ExpressionType.Multiply] = "*",
            [ExpressionType.MultiplyAssign] = "*=",
            [ExpressionType.MultiplyAssignChecked] = "*=",
            [ExpressionType.MultiplyChecked] = "*",
            [ExpressionType.Negate] = "-",
            [ExpressionType.NegateChecked] = "-",
            [ExpressionType.Not] = "!",
            [ExpressionType.NotEqual] = "!=",
            [ExpressionType.Or] = "||",
            [ExpressionType.OrAssign] = "|=",
            [ExpressionType.OrElse] = "||",
            [ExpressionType.PostDecrementAssign] = "--",
            [ExpressionType.PostIncrementAssign] = "++",
            [ExpressionType.Power] = "**",
            [ExpressionType.PowerAssign] = "**=",
            [ExpressionType.PreDecrementAssign] = "--",
            [ExpressionType.PreIncrementAssign] = "++",
            [ExpressionType.Quote] = "\"",
            [ExpressionType.RightShift] = ">>",
            [ExpressionType.RightShiftAssign] = ">>=",
            [ExpressionType.Subtract] = "-",
            [ExpressionType.SubtractAssign] = "-=",
            [ExpressionType.SubtractAssignChecked] = "-=",
            [ExpressionType.SubtractChecked] = "-",
            [ExpressionType.TypeIs] = "is",
            [ExpressionType.UnaryPlus] = "++",
        };

        private readonly TranslatorProvider translatorProvider;

        public JavaScriptTranslator(TranslatorProvider translatorProvider, DryvOptions options) : base(options)
        {
            this.translatorProvider = translatorProvider;
        }

        public bool UseLowercaseMembers { get; set; }

        public override void Translate(Expression expression, TranslationContext context, bool negated = false)
        {
            var needsBrackets = this.GetNeedsBrackets(expression);

            if (needsBrackets)
            {
                context.Writer.Write("(");
            }

            var context2 = context.Clone<CustomTranslationContext>();
            context2.Expression = expression;
            context2.Translator = this;
            context2.Negated = negated;

            if (!this.translatorProvider.GenericTranslators.Any(t => t.TryTranslate(context2)))
            {
                this.Visit((dynamic)expression, context2, negated);
            }

            if (needsBrackets)
            {
                context.Writer.Write(") ");
            }
        }

        public override string TranslateValue(object value)
        {
            switch (value)
            {
                case string txt:
                    return $"\"{txt}\"";

                case bool b:
                    return b ? "true" : "false";

                case null:
                    return "null";

                case DryvValidationResult result:
                    return TranslateValidationResultObject(result);

                default:
                    return this.Options.JsonConversion == null ? value.ToString() : this.Options.JsonConversion(value);
            }
        }

        public override void Visit(BinaryExpression expression, TranslationContext context, bool negated = false)
        {
            var isEquals = expression.NodeType == ExpressionType.Equal;
            var isNotEquals = expression.NodeType == ExpressionType.NotEqual;
            var leftIsNull = (isEquals || isNotEquals) && expression.Left is ConstantExpression c1 && c1.Value == null;
            var rightIsNull = (isEquals || isNotEquals) && expression.Right is ConstantExpression c2 && c2.Value == null;

            if ((leftIsNull || rightIsNull) && !(isNotEquals ^ negated))
            {
                context.Writer.Write("!");
            }

            if (!TryWriteInjectedExpression(expression.Left, context))
            {
                this.Translate(expression.Left, context);
            }

            if (rightIsNull)
            {
                return;
            }

            if (!leftIsNull)
            {
                if (!TryWriteTerminal(expression, context.Writer))
                {
                    throw expression.Method != null
                        ? (Exception)new DryvMethodNotSupportedException(expression)
                        : new DryvExpressionNotSupportedException(expression);
                }
            }

            if (!TryWriteInjectedExpression(expression.Right, context))
            {
                this.Translate(expression.Right, context);
            }
        }

        public override void Visit(BlockExpression expression, TranslationContext context, bool negated = false)
        {
            if (TryWriteInjectedExpression(expression, context))
            {
                return;
            }

            foreach (var variable in expression.Variables)
            {
                context.Writer.WriteLine($"var {this.FormatIdentifier(variable.Name)};");
            }

            base.Visit(expression, context, negated);
        }

        public override void Visit(ConstantExpression expression, TranslationContext context, bool negated = false)
        {
            var text = MethodCallTranslator.QuoteValue(expression.Value);

            context.Writer.Write(text);
        }

        public override void Visit(DefaultExpression expression, TranslationContext context, bool negated = false)
        {
            var value = this.GetDefaultValue(expression.Type);
            var text = MethodCallTranslator.QuoteValue(value);

            context.Writer.Write(text);
        }

        public override void Visit(DynamicExpression expression, TranslationContext context, bool negated = false)
        {
            throw new NotSupportedException();
        }

        public override void Visit(GotoExpression expression, TranslationContext context, bool negated = false)
        {
            throw new NotSupportedException();
        }

        public override void Visit(IndexExpression expression, TranslationContext context, bool negated = false)
        {
            if (expression.Arguments.Count > 1)
            {
                throw new NotSupportedException("JavaScript does not support indexers with more than one argument.");
            }

            if (TryWriteInjectedExpression(expression, context))
            {
                return;
            }

            this.Translate(expression.Object, context);
            context.Writer.Write("[");
            this.Translate(expression.Arguments.First(), context);
            context.Writer.Write("]");
        }

        public override void Visit(InvocationExpression expression, TranslationContext context, bool negated = false)
        {
            if (expression.Expression is MemberExpression)
            {
                throw new DryvExpressionNotSupportedException(expression);
            }

            if (TryWriteInjectedExpression(expression, context))
            {
                return;
            }

            this.Translate(expression.Expression, context);
            context.Writer.Write("(");
            MethodCallTranslator.WriteArguments(this, expression.Arguments, context);
            context.Writer.Write(")");
        }

        public override void Visit(LabelExpression expression, TranslationContext context, bool negated = false)
        {
            throw new NotSupportedException();
        }

        public override void Visit(LambdaExpression expression, TranslationContext context, bool negated = false)
        {
            context.Writer.Write("function(");
            context.Writer.Write(string.Join(", ", expression.Parameters.Select(p => this.FormatIdentifier(p.Name))));
            context.Writer.Write(") {");
            context.Writer.IncrementIndent();
            context.Writer.Write("return ");

            this.Translate(expression.Body, context);

            context.Writer.DecrementIndent();
            context.Writer.Write("}");
        }

        public override void Visit(ConditionalExpression expression, TranslationContext context, bool negated = false)
        {
            var finder = new BinaryFinder(this, context);

            var asyncExpression = finder.Visit(expression.Test) is BinaryExpression chain && finder.AsyncExpressions.Any()
                ? this.TranslateAsyncBooleanChain(chain, context, finder)
                : expression.Test;

            var asyncFinder = new AsyncMethodCallModifier(this, context);
            var body = asyncFinder.ApplyPromises(asyncExpression);

            foreach (var call in asyncFinder.AsyncCalls)
            {
                context.Writer.Write(call.Key.ToString());
                context.Writer.Write(".then(function(");
                context.Writer.Write(call.Value.Name);
                context.Writer.Write("){return ");
            }

            this.Translate(body, context);

            context.Writer.IncrementIndent();
            context.Writer.Write(" ? ");
            this.Translate(expression.IfTrue, context);
            context.Writer.Write(" : ");
            this.Translate(expression.IfFalse, context);
            context.Writer.DecrementIndent();

            for (var i = 0; i < asyncFinder.AsyncCalls.Count; i++)
            {
                context.Writer.Write(";})");
            }
        }

        public override void Visit(ListInitExpression expression, TranslationContext context, bool negated = false)
        {
            context.Writer.Write("= [");
            var sep = string.Empty;
            foreach (var initializer in expression.Initializers)
            {
                context.Writer.Write(sep);
                foreach (var argument in initializer.Arguments)
                {
                    this.Translate(argument, context);
                }
                sep = ", ";
            }
            context.Writer.Write("]");
        }

        public override void Visit(LoopExpression expression, TranslationContext context, bool negated = false)
        {
            throw new NotImplementedException();
        }

        public override void Visit(MemberExpression expression, TranslationContext context, bool negated = false)
        {
            var asyncFinder = new AsyncMethodCallModifier(this, context);
            var body = asyncFinder.ApplyPromises(expression);


            foreach (var call in asyncFinder.AsyncCalls)
            {
                context.Writer.Write(call.Key.ToString());
                context.Writer.Write(".then(function(");
                context.Writer.Write(call.Value.Name);
                context.Writer.Write("){return ");
            }

            if (negated)
            {
                context.Writer.Write("!(");
            }

            if (asyncFinder.AsyncCalls.Any())
            {
                this.Translate(body, context);
            }
            else
            {
                this.WriteMember(expression, context);
            }

            if (negated)
            {
                context.Writer.Write(")");
            }

            for (var i = 0; i < asyncFinder.AsyncCalls.Count; i++)
            {
                context.Writer.Write(";})");
            }

        }

        public override void Visit(MemberInitExpression expression, TranslationContext context, bool negated = false)
        {
            this.Visit(expression.NewExpression, context);
        }

        public override void Visit(MethodCallExpression expression, TranslationContext context, bool negated = false)
        {
            if (expression.Method.IsStatic && expression.Arguments.Any() != true)
            {
                if (context.WhatIfMode) return;

                var value = expression.Method.Invoke(null, null);
                context.Writer.Write(this.TranslateValue(value));
                return;
            }

            if (TryWriteInjectedMethod(expression, context))
            {
                return;
            }

            var objectType = expression.Object?.Type ?? expression.Method.DeclaringType;

            var context2 = context.Clone<MethodTranslationContext>();
            context2.Translator = this;
            context2.Expression = expression;
            context2.Negated = negated;

            if (this.translatorProvider
                .MethodCallTranslators
                .Where(t => t.SupportsType(objectType))
                .Any(t => t.Translate(context2)))
            {
                return;
            }

            throw new DryvMethodNotSupportedException(expression);
        }

        public override void Visit(NewArrayExpression expression, TranslationContext context, bool negated = false)
        {
            context.Writer.Write("[");
            foreach (var child in expression.Expressions)
            {
                this.Translate(child, context);
            }
            context.Writer.Write("]");
        }

        public override void Visit(NewExpression expression, TranslationContext context, bool negated = false)
        {
            context.Writer.Write("new ");
            context.Writer.Write(expression.Constructor.DeclaringType.Name);
            context.Writer.Write("(");
            MethodCallTranslator.WriteArguments(this, expression.Arguments, context);
            context.Writer.Write(")");
        }

        public override void Visit(ParameterExpression expression, TranslationContext context, bool negated = false)
        {
            context.Writer.Write(expression.Name);
        }

        public override void Visit(RuntimeVariablesExpression expression, TranslationContext context, bool negated = false)
        {
            throw new NotImplementedException();
        }

        public override void Visit(SwitchExpression expression, TranslationContext context, bool negated = false)
        {
            context.Writer.Write("switch(");
            if (!TryWriteInjectedExpression(expression.SwitchValue, context))
            {
                this.Translate(expression.SwitchValue, context);
            }
            context.Writer.WriteLine("){");
            foreach (var expressionCase in expression.Cases)
            {
                foreach (var testCase in expressionCase.TestValues)
                {
                    context.Writer.Write("case ");
                    this.Translate(testCase, context);
                    context.Writer.WriteLine(":");
                }

                context.Writer.WriteLine("{");
                context.Writer.IncrementIndent();
                this.Translate(expressionCase.Body, context);
                context.Writer.WriteLine();
                context.Writer.WriteLine("break;");
                context.Writer.DecrementIndent();
                context.Writer.WriteLine("}");
            }
            context.Writer.Write("}");
        }

        public override void Visit(TryExpression expression, TranslationContext context, bool negated = false)
        {
            throw new NotImplementedException();
        }

        public override void Visit(TypeBinaryExpression expression, TranslationContext context, bool negated = false)
        {
            throw new DryvExpressionNotSupportedException(expression);
        }

        public override void Visit(UnaryExpression expression, TranslationContext context, bool negated = false)
        {
            if (TryWriteInjectedExpression(expression, context))
            {
                return;
            }

            var negatedExpression = false;

            switch (expression.NodeType)
            {
                case ExpressionType.Not:
                    negatedExpression = true;
                    break;

                case ExpressionType.Convert:
                    if (string.IsNullOrWhiteSpace(context.GroupName) || !Equals(expression.Method, DryvValidationResultImplicitConvert) ||
                        expression.Operand is ConstantExpression constant && constant.Value == null)
                    {
                        break;
                    }

                    context.Writer.Write("{ type:\"error\", text:");
                    this.Translate(expression.Operand, context);
                    context.Writer.Write(", groupName: ");
                    context.Writer.Write(MethodCallTranslator.QuoteValue(context.GroupName));
                    context.Writer.Write("}");

                    return;
            }

            if (!negatedExpression)
            {
                TryWriteTerminal(expression, context.Writer);
            }

            this.Translate(expression.Operand, context, negatedExpression);
        }

        private static string TranslateValidationResultObject(DryvValidationResult result)
        {
            if (result.Type == DryvResultType.Success)
            {
                return "null";
            }

            var sb = new StringBuilder("{");

            if (!string.IsNullOrWhiteSpace(result.GroupName))
            {
                sb.Append("groupName:\"");
                sb.Append(result.GroupName);
                sb.Append("\",");
            }

            sb.Append("text:\"");
            sb.Append(result.Text);
            sb.Append("\",");
            sb.Append("type:\"");
            sb.Append(result.Type.ToString().ToLower());
            sb.Append("\"");
            sb.Append("}");

            return sb.ToString();
        }

        private static bool TryWriteInjectedExpression(Expression expression, TranslationContext context)
        {
            if (expression.Type == typeof(DryvValidationResult))
            {
                return false;
            }

            var visitor = new ExpressionNodeFinder<ParameterExpression>();
            visitor.Visit(expression);


            var visitor2 = new ExpressionNodeFinder<MethodCallExpression>();
            visitor2.Visit(expression);

            if (!visitor.FoundChildren.Any() && !visitor2.FoundChildren.Any())
            {
                return false;
            }

            // Parameters that start with '$' are generated dummy parameters and should not be injected.
            if (visitor.FoundChildren.Any(c => c.Name.StartsWith("$")))
            {
                return false;
            }

            if (visitor.FoundChildrenWithStack.Any(x => x.Value.Contains(expression) && x.Value.Any(o => o.Type == context.ModelType)))
            {
                return false;
            }

            context.InjectRuntimeExpression(expression, visitor.FoundChildren);

            return true;
        }

        private static bool TryWriteInjectedMethod(MethodCallExpression expression, TranslationContext context)
        {
            if (!expression.Type.IsSystemType())
            {
                return false;
            }

            var parameter = expression.Object.GetOuterExpression<ParameterExpression>();
            if (parameter != null && !context.OptionsTypes.Contains(parameter.Type))
            {
                return false;
            }

            if (parameter == null && !expression.Method.IsStatic)
            {
                return false;
            }

            var finder = new ExpressionNodeFinder<ParameterExpression>();
            var parameterExpressions = (from a in expression.Arguments
                                        from p in finder.FindChildren(a)
                                        where p != null
                                        select p).ToList();

            if (parameterExpressions.Any(p => p.Type == context.ModelType))
            {
                return false;
            }

            if (parameter == null && parameterExpressions.Any())
            {
                parameter = parameterExpressions.FirstOrDefault(p => context.OptionsTypes.Contains(p.Type));
            }

            if (parameter == null)
            {
                return false;
            }

            context.InjectRuntimeExpression(expression.Object ?? expression, parameter);
            return true;
        }

        private static bool TryWriteTerminal(Expression expression, TextWriter writer)
        {
            if (!Terminals.TryGetValue(expression.NodeType, out var terminal))
            {
                return false;
            }

            writer.Write(terminal);
            return true;
        }

        private string FormatIdentifier(string name)
        {
            return this.UseLowercaseMembers
                ? name.Length == 1
                    ? name.ToLower()
                    : name.Substring(0, 1).ToLower() + name.Substring(1)
                : name;
        }

        private bool GetNeedsBrackets(Expression expression)
        {
            switch (expression)
            {
                case ConstantExpression _:
                case ParameterExpression _:
                case MethodCallExpression _:
                case MemberExpression _:
                case UnaryExpression _:
                case LambdaExpression _:
                    return false;
            }

            return this.translatorProvider.GenericTranslators.All(t => t.AllowSurroundingBrackets(expression) != false);
        }

        private Expression TranslateAsyncBooleanChain(BinaryExpression chain, TranslationContext context, BinaryFinder finder)
        {
            if (finder.AsyncExpressions.Contains(chain.Left))
            {
                return this.TranslateAsyncBooleanOperand(chain.Left, context, finder);
            }

            this.Translate(chain.Left, context);

            TryWriteTerminal(chain, context.Writer);

            if (finder.AsyncExpressions.Contains(chain.Right))
            {
                return this.TranslateAsyncBooleanOperand(chain.Right, context, finder);
            }

            this.Translate(chain.Right, context);

            return Expression.Empty();
        }

        private Expression TranslateAsyncBooleanOperand(Expression expression, TranslationContext context, BinaryFinder finder)
        {
            if (expression is BinaryExpression chain && (chain.NodeType == ExpressionType.OrElse || chain.NodeType == ExpressionType.AndAlso))
            {
                return this.TranslateAsyncBooleanChain(chain, context, finder);
            }

            return expression;
        }

        private void WriteMember(MemberExpression expression, TranslationContext context)
        {
            if (TryWriteInjectedExpression(expression, context))
            {
                return;
            }

            if (expression.Expression is ConstantExpression ||
                expression.Expression == null)
            {
                var instance = (expression.Expression as ConstantExpression)?.Value;
                switch (expression.Member)
                {
                    case PropertyInfo property:
                        {
                            var value = property.GetValue(instance);
                            context.Writer.Write(this.TranslateValue(value));
                            break;
                        }
                    case FieldInfo field:
                        {
                            var value = field.GetValue(instance);
                            context.Writer.Write(this.TranslateValue(value));
                            break;
                        }
                }
            }
            else
            {
                if (context.PropertyExpression != null &&
                    expression.Expression.ToString().Contains(context.PropertyExpression.ToString()))
                {
                    var e = expression;

                    switch (e.Expression)
                    {
                        case MemberExpression mex:
                            this.Visit(mex, context);
                            break;

                        case ParameterExpression parameterExpression:
                            this.Visit(parameterExpression, context);
                            context.Writer.Write("$$MODELPATH$$");
                            break;

                        default:
                            this.Translate(expression.Expression, context);
                            break;
                    }
                }
                else
                {
                    this.Translate(expression.Expression, context);
                }

                context.Writer.Write(".");

                context.Writer.Write(this.FormatIdentifier(expression.Member.Name.ToCamelCase()));
            }
        }
    }
}