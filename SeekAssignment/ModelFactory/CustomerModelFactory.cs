using SeekAssignment.IModelFactory;
using SeekAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAssignment.ModelFactory
{
    public class CustomerModelFactory : ICustomerModelFactory
    {
        public Customer CreateCustomer(int customerId, string customerName, string customerCode)
        {
            return new Customer
            {
                CustomerId = customerId,
                CustomerName = customerName,
                CustomerCode = customerCode
            };
        }
    }
}
