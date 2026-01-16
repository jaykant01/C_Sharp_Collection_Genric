namespace Genric;

class Program
{
    static void Main(string[] args)
    {
        Storage<Electronics> elStorage = new Storage<Electronics>();
        elStorage.AddItem(new Electronics
        (
            1,
            "Laptop",
            "Acer"
        ));

        Storage<Groceries> grStorage = new Storage<Groceries>();
        grStorage.AddItem(new Groceries
        (
            2,
            "Apple",
            DateTime.Now.AddDays(3)
        ));

        Storage<Furniture> frStorage = new Storage<Furniture>();
        frStorage.AddItem(new Furniture
        (
            3,
            "Table",
            "Wood"
        ));

        elStorage.DisplayAllItems();
        grStorage.DisplayAllItems();
        frStorage.DisplayAllItems();
    }
}
