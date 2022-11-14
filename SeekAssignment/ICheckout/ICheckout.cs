using SeekAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAssignment.ICheckout
{
    public interface ICheckout
    {
        void AddItemsToCheckout(Product product);
        double GetTotalAmount();
    }
}
