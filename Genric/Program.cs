
using Online_Marketplace;


class Program
{
    static void Main(string[] args)
    {

        // Problem 1
        // Storage<Electronics> elStorage = new Storage<Electronics>();
        // elStorage.AddItem(new Electronics
        // (
        //     1,
        //     "Laptop",
        //     "Acer"
        // ));

        // Storage<Groceries> grStorage = new Storage<Groceries>();
        // grStorage.AddItem(new Groceries
        // (
        //     2,
        //     "Apple",
        //     DateTime.Now.AddDays(3)
        // ));

        // Storage<Furniture> frStorage = new Storage<Furniture>();
        // frStorage.AddItem(new Furniture
        // (
        //     3,
        //     "Table",
        //     "Wood"
        // ));

        // elStorage.DisplayAllItems();
        // grStorage.DisplayAllItems();
        // frStorage.DisplayAllItems();


        // Problem 
        var book = new Product<BookCategory>("c#", 500, new BookCategory());

        var shirt = new Product<ClothingCategory>("Nike", 15500, new ClothingCategory());

        DiscountService.ApplyDiscount(book, 10);
        DiscountService.ApplyDiscount(shirt, 20);

        Console.WriteLine($"{book.Name} - {book.Price}");
        Console.WriteLine($"{shirt.Name} - {shirt.Price}");

        Console.ReadKey();
    }
}
