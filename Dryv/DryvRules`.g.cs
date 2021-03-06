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
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, DryvResultMessage>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
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
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, bool>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, Task<bool>>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				null);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, bool>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, Task<bool>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, bool>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, Task<bool>>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				null);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, bool>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, Task<bool>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, bool>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, Task<bool>>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				null);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, bool>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, Task<bool>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, bool>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		
		public DryvRules<TModel> DisableRules(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, Task<bool>>> rule)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> Rule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> ServerRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, DryvResultMessage>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> ClientRule(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, Task<DryvResultMessage>>> rule)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				null);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, bool>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, Task<bool>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		
		public DryvRules<TModel> DisableRules<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<bool>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Disable(rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> Rule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.Add(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ServerRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddServer(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, DryvResultMessage>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(null, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }
		public DryvRules<TModel> ClientRule<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8>(string groupName,
			Expression<Func<TModel, object>> property1,
			Expression<Func<TModel, object>> property2,
			Expression<Func<TModel, object>> property3,
			Expression<Func<TModel, object>> property4,
			Expression<Func<TModel, object>> property5,
			Expression<Func<TModel, object>> property6,
			Expression<Func<TModel, object>> property7,
			Expression<Func<TModel, object>> property8,
			Expression<Func<TModel, object>> property9,
			Expression<Func<TModel, TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, Task<DryvResultMessage>>> rule,
         			Expression<Func<TOptions1, TOptions2, TOptions3, TOptions4, TOptions5, TOptions6, TOptions7, TOptions8, bool>> ruleSwitch = null)
        {
			this.AddClient(groupName, rule,
				new[] { property1, property2, property3, property4, property5, property6, property7, property8, property9, },
				ruleSwitch);
			return this;
        }

	}
}
