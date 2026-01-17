using Student;
using EmployeeLeave;
using DriverSystem;
using Library;
using Inventory;
using Shopping;
using Bank;
class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        // StudentPerformanceAnalyzer analyzer = new StudentPerformanceAnalyzer();

        // analyzer.AddStudent(new Student(1, "Amit"));
        // analyzer.AddStudent(new Student(2, "Ravi"));
        // analyzer.AddStudent(new Student(3, "Neha"));

        // analyzer.AddMarks(1, new List<int> { 45, 60, 29 });
        // analyzer.AddMarks(2, new List<int> { 40, 40, 40 });
        // analyzer.AddMarks(3, new List<int> { 20, 25, 28 });

        // analyzer.DisplayPartialFailures();
        // analyzer.DisplayTopScorers();
        // analyzer.RemoveFailedStudents();
        // analyzer.DisplayAllStudents();

        // Problem 3
        // LeaveManager manager = new LeaveManager();

        // // Holidays
        // manager.AddHoliday(new DateTime(2025, 1, 1));
        // manager.AddHoliday(new DateTime(2025, 12, 25));

        // // Leave applications
        // manager.ApplyLeave(101, new Leave(
        //     new DateTime(2025, 1, 2),
        //     new DateTime(2025, 1, 3)));

        // manager.ApplyLeave(101, new Leave(
        //     new DateTime(2025, 1, 3),
        //     new DateTime(2025, 1, 4))); 

        // manager.ApplyLeave(101, new Leave(
        //     new DateTime(2025, 12, 31),
        //     new DateTime(2026, 1, 1))); 

        // manager.GenerateLeaveReport(101);

        // Problem 5
        // CabAssignmentManager manager = new CabAssignmentManager();

        // manager.AddDriver(new Driver(1, "Ravi", 2.5, 4.6));
        // manager.AddDriver(new Driver(2, "Amit", 2.5, 4.8));
        // manager.AddDriver(new Driver(3, "Neha", 3.0, 4.9));

        // Driver assigned = manager.AssignDriver();

        // manager.CancelRide(assigned);
        // manager.AssignDriver();

        // manager.DisplayDrivers();

        // Problem 7
        // LibraryFineCalculator calculator = new LibraryFineCalculator();

        // calculator.AddRecord(1, new IssueRecord(
        //     "C#",
        //     new DateTime(2025, 1, 5),
        //     new DateTime(2025, 1, 15)));

        // calculator.AddRecord(1, new IssueRecord(
        //     "DSA",
        //     new DateTime(2025, 1, 10),
        //     new DateTime(2025, 1, 20)));

        // calculator.AddRecord(2, new IssueRecord(
        //     "DBMS",
        //     new DateTime(2025, 1, 1),
        //     new DateTime(2025, 1, 7))); 

        // calculator.GenerateMonthlyReport(1, 2025);
        // calculator.DisplayFrequentDefaulters();


        // Problem 9
        // InventoryReorderPredictor predictor = new InventoryReorderPredictor();

        // predictor.AddItem(new InventoryItem("Laptop", 20));

        // predictor.AddDailySale("Laptop", 3);
        // predictor.AddDailySale("Laptop", 4);
        // predictor.AddDailySale("Laptop", 0);
        // predictor.AddDailySale("Laptop", 5);

        // predictor.CheckReorder("Laptop");
        // predictor.PredictStockOut("Laptop");


        // Problem 2
        // ShoppingCart cart = new ShoppingCart();

        // cart.AddOffer(new Offer("Buy 2 Get 1"));
        // cart.AddOffer(new Offer("10% Discount"));
        // cart.AddOffer(new Offer("Free Delivery"));

        // cart.AddItem(new CartItem(1, "Shoes", 2000, 3));
        // cart.AddItem(new CartItem(2, "Bag", 1500, 2));

        // cart.Checkout();


        // Problem 4
        FraudDetector detector = new FraudDetector();

        detector.AddAccount(1001, 10000);

        detector.ProcessTransaction(1001,
            new Transaction(DateTime.Now, 2000, "WITHDRAW"));

        detector.ProcessTransaction(1001,
            new Transaction(DateTime.Now.AddMinutes(2), 1500, "WITHDRAW"));

        detector.ProcessTransaction(1001,
            new Transaction(DateTime.Now.AddMinutes(4), 1000, "WITHDRAW"));

        detector.ProcessTransaction(1001,
            new Transaction(DateTime.Now.AddMinutes(6), 900, "WITHDRAW"));

        detector.GenerateSuspiciousReport();


    }
}
