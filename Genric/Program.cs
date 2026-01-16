using Online_Marketplace;
using Course_Management;
using Meal_Plan;
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


        // Problem 2
        // var book = new Product<BookCategory>("c#", 500, new BookCategory());

        // var shirt = new Product<ClothingCategory>("Nike", 15500, new ClothingCategory());

        // DiscountService.ApplyDiscount(book, 10);
        // DiscountService.ApplyDiscount(shirt, 20);

        // Console.WriteLine($"{book.Name} - {book.Price}");
        // Console.WriteLine($"{shirt.Name} - {shirt.Price}");

        // Problem 3
        // Course<ExamCourse> examCourse = new Course<ExamCourse>();
        // examCourse.AddCourse(new ExamCourse("Data Structures"));
        // examCourse.AddCourse(new ExamCourse("Operating Systems"));

        // Course<AssignmentCourse> assignmentC = new Course<AssignmentCourse>();
        // assignmentC.AddCourse(new AssignmentCourse("Software Engineering"));
        // assignmentC.AddCourse(new AssignmentCourse("Web Development"));

        // Console.WriteLine("Exam Courses:");
        // examCourse.DisplayCourses();

        // Console.WriteLine("\nAssignment Courses:");
        // assignmentC.DisplayCourses();

        // Problem 4
        var vegMeal = MealGenerator.GenerateMeal(new VegetarianMeal());
        vegMeal.Display();

        var ketoMeal = MealGenerator.GenerateMeal(new VeganMeal());
        ketoMeal.Display();

        Console.ReadKey();
    }
}
