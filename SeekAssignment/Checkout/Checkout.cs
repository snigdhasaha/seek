using SeekAssignment.Model;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAssignment.Checkout
{
    public class Checkout : ICheckout.ICheckout
    {
        private List<PriceRule>? _priceRules;
        private List<Product> _checkoutProducts;

        public List<Product> CheckoutProducts
        {
            get {
                return _checkoutProducts;
            }
            set { _checkoutProducts = value; }
        }
        public Checkout(List<PriceRule>? priceRules)
        {
            _priceRules = priceRules;
            _checkoutProducts = new List<Product>();
        }
        public void AddItemsToCheckout(Product product)
        {
            CheckoutProducts.Add(product);
        }

        public double GetTotalAmount()
        {
            int count = 0;
            double totalAmount = 0;
            foreach(var product in CheckoutProducts)
            {
                if(_priceRules != null && _priceRules.Count > 0)
                {
                    if (_priceRules.Any(r => r.ProductId == product.ProductId))
                    {
                        var priceRule = _priceRules.Single(r => r.ProductId == product.ProductId);
                        if(priceRule.IsCountBy == true)
                        {
                            count++;
                            if(count % priceRule.GiveItems != 0)
                            {
                                totalAmount += product.Price;
                            }
                        }
                        if(priceRule.IsDiscountBy == true)
                        {
                            totalAmount += priceRule.DiscountAmount;
                        }
                    }
                    else
                    {
                        totalAmount+=product.Price;
                    }
                }
                else{
                    totalAmount += product.Price;
                }
                
            }

            return totalAmount;
        }
    }
}
