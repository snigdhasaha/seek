using SeekAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAssignment.IModelFactory
{
    public interface IProductModelFactory
    {
        Product CreatedProduct(int productId, string productName, string productCode, double price);
    }
}
