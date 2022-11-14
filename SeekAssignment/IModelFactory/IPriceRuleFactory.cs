using SeekAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAssignment.IModelFactory
{
    public interface IPriceRuleFactory
    {
        PriceRule CreateCountByRule(int ruleId, int customerId, int productId, string name, int giveItem, int forItem);
        PriceRule CreateDiscountByRule(int ruleId, int customerId, int productId, string name, double discountAmount);
    }
}
