﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Dryv.Rules
{
    public partial class DryvRules<TModel> : DryvRules
    {
        internal DryvRules()
        {
        }

        private void Add<TProperty>(
            string groupName,
            Expression<Func<TModel, TProperty>> property,
            LambdaExpression rule,
            LambdaExpression enabled,
            string ruleName,
            DryvRuleLocation ruleLocation)
        {
            var ruleDefinition = DryvCompiledRule.Create(property, rule, enabled, ruleLocation, groupName);
            ruleDefinition.Name = ruleName;

            this.ValidationRules.Add(ruleDefinition);
        }

        private void Disable<TProperty>(
            Expression<Func<TModel, TProperty>> property,
            LambdaExpression rule,
            LambdaExpression enabled,
            DryvRuleLocation ruleLocation)
        {
            var ruleDefinition = DryvCompiledRule.Create(property, rule, enabled, ruleLocation, null);
            ruleDefinition.IsDisablingRule = true;

            this.DisablingRules.Add(ruleDefinition);
        }

        private void Disable<TProperty>(
            LambdaExpression rule,
            IEnumerable<Expression<Func<TModel, TProperty>>> properties,
            LambdaExpression ruleSwitch)
        {
            foreach (var property in properties)
            {
                this.Disable(property, rule, ruleSwitch, DryvRuleLocation.Server | DryvRuleLocation.Client);
            }
        }

        private void Add<TProperty>(
            string groupName,
            LambdaExpression rule,
            IEnumerable<Expression<Func<TModel, TProperty>>> properties,
            LambdaExpression ruleSwitch,
            string ruleName)
        {
            foreach (var property in properties)
            {
                this.Add(groupName, property, rule, ruleSwitch, ruleName, DryvRuleLocation.Server | DryvRuleLocation.Client);
            }
        }

        private void AddServer<TProperty>(
            string groupName,
            LambdaExpression rule,
            IEnumerable<Expression<Func<TModel, TProperty>>> properties,
            LambdaExpression ruleSwitch,
            string ruleName)
        {
            foreach (var property in properties)
            {
                this.Add(groupName, property, rule, ruleSwitch, ruleName, DryvRuleLocation.Server);
            }
        }

        private void AddClient<TProperty>(
            string groupName,
            LambdaExpression rule,
            IEnumerable<Expression<Func<TModel, TProperty>>> properties,
            LambdaExpression ruleSwitch,
        string ruleName)
        {
            foreach (var property in properties)
            {
                this.Add(groupName, property, rule, ruleSwitch, ruleName, DryvRuleLocation.Client);
            }
        }
    }
}