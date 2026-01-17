namespace Student;

class Program
{
    static void Main(string[] args)
    {
        StudentPerformanceAnalyzer analyzer = new StudentPerformanceAnalyzer();

        analyzer.AddStudent(new Student(1, "Amit"));
        analyzer.AddStudent(new Student(2, "Ravi"));
        analyzer.AddStudent(new Student(3, "Neha"));

        analyzer.AddMarks(1, new List<int> { 45, 60, 29 });
        analyzer.AddMarks(2, new List<int> { 40, 40, 40 });
        analyzer.AddMarks(3, new List<int> { 20, 25, 28 });

        analyzer.DisplayPartialFailures();
        analyzer.DisplayTopScorers();
        analyzer.RemoveFailedStudents();
        analyzer.DisplayAllStudents();
    }
}
