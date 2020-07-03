﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Dryv.AspNetCore.DynamicControllers.CodeGeneration;
using Dryv.AspNetCore.DynamicControllers.Endpoints;
using Dryv.Translation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Options;

namespace Dryv.AspNetCore.DynamicControllers.Translation
{
    internal class DryvDynamicControllerTranslator : /*ICustomTranslator,*/ IMethodCallTranslator
    {
        private static readonly ConcurrentDictionary<string, Lazy<TypeInfo>> Controllers = new ConcurrentDictionary<string, Lazy<TypeInfo>>();
        private readonly ControllerGenerator codeGenerator;
        private readonly IDryvClientServerCallWriter controllerCallWriter;
        private readonly DryvDynamicControllerRegistration controllerRegistration;
        private readonly LinkGenerator linkGenerator;
        private readonly IOptions<DryvDynamicControllerOptions> options;

        public DryvDynamicControllerTranslator(DryvDynamicControllerRegistration controllerRegistration, ControllerGenerator codeGenerator, IDryvClientServerCallWriter controllerCallWriter, IOptions<DryvDynamicControllerOptions> options, LinkGenerator linkGenerator)
        {
            this.controllerRegistration = controllerRegistration;
            this.codeGenerator = codeGenerator;
            this.controllerCallWriter = controllerCallWriter;
            this.options = options;
            this.linkGenerator = linkGenerator;
        }

        public bool? AllowSurroundingBrackets(Expression expression)
        {
            return true;
        }

        public int? OrderIndex { get; set; } = int.MaxValue;

        public bool SupportsType(Type type)
        {
            return true;
        }

        public bool Translate(MethodTranslationContext context)
        {
            return this.Translate(context, context.Translator, context.Expression);
        }

        public bool TryTranslate(CustomTranslationContext context)
        {
            return this.Translate(context, context.Translator, context.Expression);
        }

        private static List<MemberExpression> FindModelPropertiesInExpression(TranslationContext context, MethodCallExpression methodCallExpression)
        {
            var f = new ControllerGenerator.ChildFinder<MemberExpression>();

            foreach (var argument in methodCallExpression.Arguments)
            {
                f.Visit(argument);
            }

            return f.FoundChildren
                .Where(e => e.Member is PropertyInfo)
                .Where(e => e.Member.DeclaringType == context.ModelType)
                .ToList();
        }

        private TypeInfo GenerateController(MethodCallExpression methodCallExpression, TranslationContext context)
        {
            var m = methodCallExpression.Method;
            var key = $"{m.DeclaringType?.FullName}|{m.Name}|{string.Join("|", m.GetParameters().Select(p => p.ParameterType.FullName))}";

            return Controllers.GetOrAdd(key, _ => new Lazy<TypeInfo>(() =>
            {
                var assembly = this.codeGenerator.CreateControllerAssembly(methodCallExpression, context.ModelType);
                this.controllerRegistration.Register(assembly, methodCallExpression.Method);

                return assembly.DefinedTypes.FirstOrDefault(typeof(Controller).IsAssignableFrom);
            })).Value;
        }

        private bool Translate(TranslationContext context, ITranslator translator, Expression expression)
        {
            if (!(expression is MethodCallExpression methodCallExpression))
            {
                return false;
            }

            //if (!typeof(Task).IsAssignableFrom(methodCallExpression.Method.ReturnType))
            //{
            //    return false;
            //}

            //if (typeof(Task).IsAssignableFrom(methodCallExpression.Method.DeclaringType))
            //{
            //    if (methodCallExpression.Method.Name != nameof(Task.FromResult))
            //    {
            //        return false;
            //    }

            //    translator.Translate(methodCallExpression.Arguments.First(), context);
            //    return true;
            //}
            if (typeof(Task).IsAssignableFrom(methodCallExpression.Method.DeclaringType) && methodCallExpression.Method.Name == nameof(Task.FromResult))
            {
                translator.Translate(methodCallExpression.Arguments.First(), context);
                return true;
            }

            var controller = this.GenerateController(methodCallExpression, context);
            var url = this.linkGenerator.GetPathByRouteValues(controller.Name, null);
            var httpMethod = this.options.Value.HttpMethod.ToString().ToUpper();
            var usedProperties = FindModelPropertiesInExpression(context, methodCallExpression);

            this.controllerCallWriter.Write(context, translator, url, httpMethod, usedProperties);

            return true;
        }
    }
}