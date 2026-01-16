namespace Course_Management;

public class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course)
    {
        courses.Add(course);
    }

    public void DisplayCourses()
    {
        foreach (T item in courses)
        {
            item.Evaluate();
        }
    }
}
