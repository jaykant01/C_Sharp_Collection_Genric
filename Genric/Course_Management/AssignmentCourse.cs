namespace Course_Management;

public class AssignmentCourse : CourseType
{
    public AssignmentCourse(string courseName) : base(courseName) { }

    public override void Evaluate()
    {
        Console.WriteLine($"{CourseName}: Evaluation based on assignments.");
    }
}
