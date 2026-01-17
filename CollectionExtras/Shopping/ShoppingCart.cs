using System;
using System.Collections.Generic;
namespace Shopping;

public class ShoppingCart
{
    private Dictionary<int, CartItem> cart =
        new Dictionary<int, CartItem>();

    private List<Offer> offers = new List<Offer>();

    // Add offers
    public void AddOffer(Offer offer)
    {
        offers.Add(offer);
    }

    // Add item to cart
    public void AddItem(CartItem item)
    {
        if (cart.ContainsKey(item.ItemId))
        {
            cart[item.ItemId].Quantity += item.Quantity;
        }
        else
        {
            cart[item.ItemId] = item;
        }
    }

    // Remove item 
    public void RemoveItem(int itemId, int quantity)
    {
        if (!cart.ContainsKey(itemId))
            return;

        cart[itemId].Quantity -= quantity;

        if (cart[itemId].Quantity <= 0)
            cart.Remove(itemId);
    }

    // Calculate total cart value
    private int CalculateCartTotal()
    {
        int total = 0;

        foreach (CartItem item in cart.Values)
        {
            total += item.TotalPrice();
        }
        return total;
    }

    // Count total items
    private int GetTotalItemCount()
    {
        int count = 0;

        foreach (CartItem item in cart.Values)
        {
            count += item.Quantity;
        }
        return count;
    }

    // Apply best offer
    private int CalculateBestDiscount()
    {
        int bestDiscount = 0;
        int cartTotal = CalculateCartTotal();

        
        foreach (CartItem item in cart.Values)
        {
            if (item.Quantity >= 3)
            {
                int freeItems = item.Quantity / 3;
                int discount = freeItems * item.Price;

                if (discount > bestDiscount)
                    bestDiscount = discount;
            }
        }

        
        if (cartTotal > 5000)
        {
            int discount = cartTotal * 10 / 100;
            if (discount > bestDiscount)
                bestDiscount = discount;
        }

        return bestDiscount;
    }

    // Generate final bill
    public void Checkout()
    {
        if (cart.Count == 0)
        {
            Console.WriteLine("Cart is empty. Nothing to checkout.");
            return;
        }

        int total = CalculateCartTotal();
        int discount = CalculateBestDiscount();
        int finalAmount = total - discount;

        Console.WriteLine("\n BILL DETAILS ");

        foreach (CartItem item in cart.Values)
        {
            Console.WriteLine(
                item.Name +
                " Qty: " + item.Quantity +
                " Price: ₹" + item.TotalPrice());
        }

        Console.WriteLine("");
        Console.WriteLine("Cart Total: ₹" + total);
        Console.WriteLine("Best Discount Applied: ₹" + discount);

        if (GetTotalItemCount() >= 5)
            Console.WriteLine("Delivery Charge: FREE");
        else
            Console.WriteLine("Delivery Charge: ₹50");

        Console.WriteLine("Final Amount: ₹" + finalAmount);
    }
}
