using System;
using System.Collections.Generic;
namespace Inventory;

public class InventoryReorderPredictor
{
    private Dictionary<string, Queue<int>> salesData =
        new Dictionary<string, Queue<int>>();

    private Dictionary<string, InventoryItem> inventory =
        new Dictionary<string, InventoryItem>();

    private const int MAX_DAYS = 7;

    // Add inventory item
    public void AddItem(InventoryItem item)
    {
        if (item.Stock < 0)
            item.Stock = 0; 
        inventory[item.ItemName] = item;
        salesData[item.ItemName] = new Queue<int>();
    }

    // Maintain last 7 days sales
    public void AddDailySale(string itemName, int quantity)
    {
        if (!salesData.ContainsKey(itemName))
            return;

        if (quantity < 0)
            quantity = 0; 

        Queue<int> queue = salesData[itemName];

        if (queue.Count == MAX_DAYS)
            queue.Dequeue(); 

        queue.Enqueue(quantity);
    }

    //  Calculate moving average
    public double CalculateMovingAverage(string itemName)
    {
        if (!salesData.ContainsKey(itemName))
            return 0;

        Queue<int> queue = salesData[itemName];

        if (queue.Count == 0)
            return 0;

        int sum = 0;
        int count = queue.Count;

        foreach (int sale in queue)
            sum += sale;

        return (double)sum / count; 
    }

    // Trigger reorder
    public void CheckReorder(string itemName)
    {
        if (!inventory.ContainsKey(itemName))
            return;

        double avg = CalculateMovingAverage(itemName);
        int stock = inventory[itemName].Stock;

        Console.WriteLine("\nItem: " + itemName);
        Console.WriteLine("Stock: " + stock);
        Console.WriteLine("Avg Sales: " + avg);

        if (avg > stock)
            Console.WriteLine("Reorder Required");
        else
            Console.WriteLine("Stock Sufficient");
    }

    // Predict stock-out date 
    public void PredictStockOut(string itemName)
    {
        if (!inventory.ContainsKey(itemName))
            return;

        double avg = CalculateMovingAverage(itemName);
        int stock = inventory[itemName].Stock;

        if (avg <= 0)
        {
            Console.WriteLine("Stock-out cannot be predicted (no sales).");
            return;
        }

        if (stock <= 0)
        {
            Console.WriteLine("Stock already exhausted.");
            return;
        }

        int days = (int)Math.Ceiling(stock / avg);
        Console.WriteLine("Estimated stock-out in " + days + " days.");
    }
}
