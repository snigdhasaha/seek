// See https://aka.ms/new-console-template for more information
using SeekAssignment.Checkout;
using SeekAssignment.IModelFactory;
using SeekAssignment.Model;
using SeekAssignment.ModelFactory;
using System.Text;

Console.WriteLine("Hello, World!");

#region Create customers
CustomerModelFactory customerModelFactory = new CustomerModelFactory();
var customerSecondBite = customerModelFactory.CreateCustomer(1001, "Second bite", "SCB");
var customerAxil = customerModelFactory.CreateCustomer(1002, "Axil", "AXL");
var customerMyer = customerModelFactory.CreateCustomer(1003, "Myer", "MYR");
var customerDefault = customerModelFactory.CreateCustomer(1004, "Default", "DFT");
#endregion

#region Create products
ProductModelFactory productModelFactory = new ProductModelFactory();
List<Product> products = new List<Product>();
products.Add(productModelFactory.CreatedProduct(2001, "classic", "CLASSIC", 269.99));
products.Add(productModelFactory.CreatedProduct(2002, "standout", "Allows advertisers to use a company logo and use a longer presentation text", 322.99));
products.Add(productModelFactory.CreatedProduct(2003, "premium", "Same benefits as Standout Ad, but also puts the advertisement at the top of the results, allowing higher visibility", 394.99));
#endregion

#region Define price rules 
PriceRuleFactory PriceRuleFactory = new PriceRuleFactory();
List<PriceRule> priceRulesAll = new List<PriceRule>();
priceRulesAll.Add(PriceRuleFactory.CreateCountByRule(1, 1001, 2001, "3 for 2 on classic ads", 3, 2));
priceRulesAll.Add(PriceRuleFactory.CreateDiscountByRule(2, 1002, 2002, "Discount on standout ads", 299.99));
priceRulesAll.Add(PriceRuleFactory.CreateDiscountByRule(3, 1003, 2003, "Discount on premium ads", 389.99));
priceRulesAll.Add(PriceRuleFactory.CreateCountByRule(4, 1003, 2002, "5 for 4 on standout ads", 5, 4));
#endregion

#region Test#1 - Second Bite
//Get the price rules for second bite
var priceRulesForSecondBite = priceRulesAll.Where(pr => pr.CustomerId == customerSecondBite.CustomerId).ToList();

// Checkout the items
Checkout checkoutSecondBite = new Checkout(priceRulesForSecondBite);
checkoutSecondBite.AddItemsToCheckout(products[0]);
checkoutSecondBite.AddItemsToCheckout(products[0]);
checkoutSecondBite.AddItemsToCheckout(products[0]);
checkoutSecondBite.AddItemsToCheckout(products[2]);

//Total amount
var totalAmountSecondBite = checkoutSecondBite.GetTotalAmount();
Console.WriteLine("Customer: " + customerSecondBite.CustomerName);
StringBuilder str = new StringBuilder();
foreach(var _ in checkoutSecondBite.CheckoutProducts)
{
    str.AppendFormat("{0}, ", _.ProductName);    
}
Console.WriteLine("items: " + str);
Console.WriteLine(totalAmountSecondBite);
#endregion 

#region Test#2 - Axil
//Get the price rules for Axil
var priceRulesForAxil = priceRulesAll.Where(pr => pr.CustomerId == customerAxil.CustomerId).ToList();

//Checkout
Checkout checkoutAxil = new Checkout(priceRulesForAxil);
checkoutAxil.AddItemsToCheckout(products[1]);
checkoutAxil.AddItemsToCheckout(products[1]);
checkoutAxil.AddItemsToCheckout(products[1]);
checkoutAxil.AddItemsToCheckout(products[2]);

var totalAmountAxil = checkoutAxil.GetTotalAmount();

Console.WriteLine("Customer: " + customerAxil.CustomerName);

str = new StringBuilder();
foreach (var _ in checkoutAxil.CheckoutProducts)
{
    str.AppendFormat("{0}, ", _.ProductName);

}
Console.WriteLine("items: " + str);
Console.WriteLine(totalAmountAxil);
#endregion

#region Test - Default
//Get the price rules for Axil
var priceRulesForDefault = priceRulesAll.Where(pr => pr.CustomerId == customerDefault.CustomerId).ToList();

//Checkout
Checkout checkoutDefault = new Checkout(priceRulesForDefault);
checkoutDefault.AddItemsToCheckout(products[0]);
checkoutDefault.AddItemsToCheckout(products[1]);
checkoutDefault.AddItemsToCheckout(products[2]);

var totalAmountDefault = checkoutDefault.GetTotalAmount();

Console.WriteLine("Customer: " + customerDefault.CustomerName);

str = new StringBuilder();
foreach (var _ in checkoutDefault.CheckoutProducts)
{
    str.AppendFormat("{0}, ", _.ProductName);
}
Console.WriteLine("items: " + str);
Console.WriteLine(totalAmountDefault);
#endregion
