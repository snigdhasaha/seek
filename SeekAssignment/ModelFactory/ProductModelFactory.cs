using SeekAssignment.IModelFactory;
using SeekAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAssignment.ModelFactory
{
    public class ProductModelFactory : IProductModelFactory
    {
        public Product CreatedProduct(int productId, string productName, string productCode, double price)
        {
            return new Product
            {
                ProductId = productId,
                ProductName = productName,
                ProductCode = productCode,
                Price = price
            };
        }
    }
}
