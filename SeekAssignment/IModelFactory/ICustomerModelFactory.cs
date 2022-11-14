using SeekAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAssignment.IModelFactory
{
    public interface ICustomerModelFactory
    {
        Customer CreateCustomer(int customerId, string customerName, string customerCode);        
    }
}
