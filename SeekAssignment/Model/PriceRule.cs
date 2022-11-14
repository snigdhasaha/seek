using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAssignment.Model
{
    public class PriceRule
    {
        public int RuleId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public Boolean IsCountBy { get; set; }
        public Boolean IsDiscountBy { get; set; }
        public int GiveItems { get; set; }
        public int ForItems { get; set; }
        public double DiscountAmount { get; set; }
    }
}
