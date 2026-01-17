namespace Shopping;

public class CartItem
{
    public int ItemId;
    public string Name;
    public int Price;
    public int Quantity;

    public CartItem(int itemId, string name, int price, int quantity)
    {
        ItemId = itemId;
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public int TotalPrice()
    {
        return Price * Quantity;
    }
}
