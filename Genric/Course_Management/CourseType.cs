namespace Course_Management;

public abstract class CourseType
{
    public string CourseName { get; set; }

    public CourseType(string courseName)
    {
        CourseName = courseName;
    }

    public abstract void Evaluate();
}
