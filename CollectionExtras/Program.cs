using Student;
using EmployeeLeave;
using DriverSystem;
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
        CabAssignmentManager manager = new CabAssignmentManager();

        manager.AddDriver(new Driver(1, "Ravi", 2.5, 4.6));
        manager.AddDriver(new Driver(2, "Amit", 2.5, 4.8));
        manager.AddDriver(new Driver(3, "Neha", 3.0, 4.9));

        Driver assigned = manager.AssignDriver();

        manager.CancelRide(assigned);
        manager.AssignDriver();

        manager.DisplayDrivers();
    }
}
