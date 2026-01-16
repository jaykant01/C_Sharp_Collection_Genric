namespace Genric;

public class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(int id, string name, string material) : base(id, name)
    {
       this.Material = material; 
    }

    public override void Display()
    {
        Console.WriteLine($"Furniture - Id: {Id}, Name: {Name}, Material: {Material}");
    }
}
