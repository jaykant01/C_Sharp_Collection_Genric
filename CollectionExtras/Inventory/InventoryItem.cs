namespace Inventory;

public class InventoryItem
{
    public string ItemName;
    public int Stock;

    public InventoryItem(string itemName, int stock)
    {
        ItemName = itemName;
        Stock = stock;
    }
}
