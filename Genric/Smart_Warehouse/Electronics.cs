namespace Genric;

public class Electronics : WarehouseItem
{
    public string Brand {get;}

    public Electronics(int id, string name, string brand) : base(id, name)
    {
        this.Brand = brand;
    }

    public override void Display()
    {
        System.Console.WriteLine($"Electronics: Id: {Id}, Name: {Name}, Brand: {Brand}");
    }
}
