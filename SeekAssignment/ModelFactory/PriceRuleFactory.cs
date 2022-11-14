using SeekAssignment.IModelFactory;
using SeekAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAssignment.ModelFactory
{
    public class PriceRuleFactory : IPriceRuleFactory
    {
        public PriceRule CreateCountByRule(int ruleId, int customerId, int productId, string name, int giveItem, int forItem)
        {
            return new PriceRule
            {
                RuleId = ruleId,
                CustomerId = customerId,
                ProductId = productId,
                Name = name,
                IsCountBy = true,
                IsDiscountBy = false,
                GiveItems = giveItem,
                ForItems = forItem
            };
        }

        public PriceRule CreateDiscountByRule(int ruleId, int customerId, int productId, string name, double discountAmount)
        {
            return new PriceRule
            {
                RuleId = ruleId,
                CustomerId= customerId,
                ProductId= productId,
                Name = name,
                IsCountBy = false,
                IsDiscountBy = true,
                DiscountAmount = discountAmount
            };
        }
    }
}
