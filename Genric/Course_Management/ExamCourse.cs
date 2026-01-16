namespace Course_Management;

public class ExamCourse : CourseType
{
    public ExamCourse(string courseName) : base(courseName) { }

    public override void Evaluate()
    {
        Console.WriteLine($"{CourseName}: Evaluation based on written exams.");
    }
}
