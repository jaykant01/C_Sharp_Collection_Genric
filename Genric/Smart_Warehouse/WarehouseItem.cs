namespace Genric;

public abstract class WarehouseItem
{
    public int Id {get;}
    public string Name {get;}

    public WarehouseItem(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }

    public abstract void Display();
}
