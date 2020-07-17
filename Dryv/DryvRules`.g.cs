using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dryv.Validation;

namespace Dryv.Rules
{
    partial class DryvRules<TModel>
    {

		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, bool>> rule)
        {
			this.Disable(rule,
				new[] { property1, },
				null);
			return this;
        }
		
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<bool>>> rule)
        {
			this.Disable(rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.Add(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.Add(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, bool>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<bool>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, bool>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<bool>>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, bool>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, Task<bool>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, bool>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, Task<bool>>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				null);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, bool>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, Task<bool>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, bool>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, Task<bool>>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				null);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, bool>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, Task<bool>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, bool>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, Task<bool>>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, DryvValidationResult>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, Task<DryvValidationResult>>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				null);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, bool>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, Task<bool>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvValidationResult>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvValidationResult>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }

	}
}
