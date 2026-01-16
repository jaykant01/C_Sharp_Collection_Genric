using System.Collections.Generic;
using System.Linq;
namespace Collections;

public class ShoppingCart
{
    // Store product prices
    private Dictionary<string, double> products = new Dictionary<string, double>();

    // LinkedDictionary equivalent
    private List<string> insertionOrder = new List<string>();

    // Add product to cart
    public void AddProduct(string name, double price)
    {
        if (!products.ContainsKey(name))
        {
            products[name] = price;
            insertionOrder.Add(name);
        }
    }

    // Display products in insertion order
    public void ShowCart()
    {
        Console.WriteLine("Shopping Cart (Insertion Order):");
        foreach (var item in insertionOrder)
            Console.WriteLine(item + " : " + products[item]);
    }

    // Display products sorted by price
    public void ShowSortedByPrice()
    {
        SortedDictionary<double, string> sorted =
            new SortedDictionary<double, string>();

        foreach (var item in products)
            sorted[item.Value] = item.Key;

        Console.WriteLine("Shopping Cart (Sorted by Price):");
        foreach (var item in sorted)
            Console.WriteLine(item.Value + " : " + item.Key);
    }
}
