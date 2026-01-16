namespace Genric;

public class Groceries : WarehouseItem
{
    public DateTime ExpiryDate { get; set; }

    public Groceries(int id, string name, DateTime expiryDate) : base(id, name)
    {
        this.ExpiryDate = expiryDate;
    }
    

    public override void Display()
    {
        Console.WriteLine($"Groceries - Id: {Id}, Name: {Name}, Expiry: {ExpiryDate}");
    }
}
