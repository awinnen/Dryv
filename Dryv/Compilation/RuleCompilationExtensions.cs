﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Dryv
{
    internal static class RuleCompilationExtensions
    {
        public static DryvRule Compile(this DryvRule rule)
        {
            if (rule.CompiledValidationExpression != null)
            {
                return rule;
            }

            rule.CompiledValidationExpression = rule.CompileValidationExpression();
            rule.CompiledEnablingExpression = rule.CompileEnablingExpression();

            return rule;
        }

        public static bool IsEnabled(this DryvRule rule, Func<Type, object> objectFactory)
        {
            rule.Compile();
            var options = rule.GetPreevaluationOptions(objectFactory);

            return rule.CompiledEnablingExpression(options);
        }

        public static DryvResult Validate(this DryvRule rule, object model, Func<Type, object> objectFactory)
        {
            rule.Compile();
            var options = rule.GetPreevaluationOptions(objectFactory);

            return rule.CompiledValidationExpression(model, options);
        }

        private static void AddOptionParameters(this List<Expression> invokeArguments, 
            LambdaExpression lambdaExpression, 
            Expression optionsParameters,
            int skip = 0)
        {
            var index = 0;

            invokeArguments.AddRange(from options in lambdaExpression.Parameters.Skip(skip)
                                     let indexConstant = Expression.Constant(index++)
                                     let arrayAccess = Expression.ArrayAccess(optionsParameters, indexConstant)
                                     select Expression.Convert(arrayAccess, options.Type));
        }

        private static Func<object[], bool> CompileEnablingExpression(this DryvRule rule)
        {
            var lambdaExpression = rule.EnablingExpression;
            rule.EnsurePreevaluationOptionTypes();

            var optionsParameter = Expression.Parameter(typeof(object[]), "options");
            Expression<Func<object[], bool>> resultLambda;
            if (lambdaExpression != null)
            {
                var invokeArguments = new List<Expression>();
                invokeArguments.AddOptionParameters(lambdaExpression, optionsParameter);
                var invokeExpression = Expression.Invoke(lambdaExpression, invokeArguments);
                resultLambda = Expression.Lambda<Func<object[], bool>>(invokeExpression, optionsParameter);
            }
            else
            {
                resultLambda = Expression.Lambda<Func<object[], bool>>(Expression.Constant(true), optionsParameter);
            }

            return resultLambda.Compile();
        }

        private static Func<object, object[], DryvResult> CompileValidationExpression(this DryvRule rule)
        {
            var lambdaExpression = rule.ValidationExpression;
            rule.EnsurePreevaluationOptionTypes();

            var modelParameter = Expression.Parameter(typeof(object), "model");
            var optionsParameter = Expression.Parameter(typeof(object[]), "options");
            var invokeArguments = new List<Expression>
            {
                Expression.Convert(modelParameter, lambdaExpression.Parameters.First().Type)
            };

            invokeArguments.AddOptionParameters(lambdaExpression, optionsParameter, 1);

            var invokeExpression = Expression.Invoke(lambdaExpression, invokeArguments);
            var resultLambda = Expression.Lambda<Func<object, object[], DryvResult>>(invokeExpression, modelParameter, optionsParameter);
            return resultLambda.Compile();
        }

        private static void EnsurePreevaluationOptionTypes(this DryvRule rule)
        {
            if (rule.PreevaluationOptionTypes?.Any() != true)
            {
                rule.PreevaluationOptionTypes = (from p in rule.ValidationExpression.Parameters
                                                 select p.Type).ToArray();
            }
        }

        private static object[] GetPreevaluationOptions(this DryvRule rule, Func<Type, object> objectFactory)
        {
            return (from t in rule.PreevaluationOptionTypes
                    select objectFactory(t)).ToArray();
        }
    }
}