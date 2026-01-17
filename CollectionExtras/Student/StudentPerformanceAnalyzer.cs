using System;
using System.Collections.Generic;
namespace Student;

public class StudentPerformanceAnalyzer
{
    private List<Student> students = new List<Student>();
    private Dictionary<int, List<int>> marks = new Dictionary<int, List<int>>();

    // Add student (handle duplicate roll numbers)
    public void AddStudent(Student student)
    {
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].RollNo == student.RollNo)
            {
                Console.WriteLine("Duplicate Roll No ignored: " + student.RollNo);
                return;
            }
        }
        students.Add(student);
    }

    public void AddMarks(int rollNo, List<int> subjectMarks)
    {
        marks[rollNo] = subjectMarks;
    }

    // 1 Calculate average marks
    public double CalculateAverage(int rollNo)
    {
        if (!marks.ContainsKey(rollNo) || marks[rollNo].Count == 0)
            return 0;

        int sum = 0;
        List<int> studentMarks = marks[rollNo];

        for (int i = 0; i < studentMarks.Count; i++)
            sum += studentMarks[i];

        return (double)sum / studentMarks.Count;
    }

    // 2 Pass condition
    public bool IsPassed(int rollNo)
    {
        if (!marks.ContainsKey(rollNo) || marks[rollNo].Count == 0)
            return false;

        double avg = CalculateAverage(rollNo);

        for (int i = 0; i < marks[rollNo].Count; i++)
        {
            if (marks[rollNo][i] < 30)
                return false;
        }

        return avg >= 40;
    }

    // 3a failed in at least one subject
    public void DisplayPartialFailures()
    {
        Console.WriteLine("\nPassed overall but failed in at least one subject:");

        for (int i = 0; i < students.Count; i++)
        {
            Student s = students[i];

            if (!marks.ContainsKey(s.RollNo)) continue;

            double avg = CalculateAverage(s.RollNo);
            bool hasFail = false;

            for (int j = 0; j < marks[s.RollNo].Count; j++)
            {
                if (marks[s.RollNo][j] < 30)
                {
                    hasFail = true;
                    break;
                }
            }

            if (avg >= 40 && hasFail)
                Console.WriteLine(s.Name + " (Roll " + s.RollNo + ")");
        }
    }

    // 3b Top scorer of each subject
    public void DisplayTopScorers()
    {
        Console.WriteLine("\nTop scorer of each subject:");

        int maxSubjects = 0;

        foreach (var m in marks.Values)
        {
            if (m.Count > maxSubjects)
                maxSubjects = m.Count;
        }

        for (int subject = 0; subject < maxSubjects; subject++)
        {
            int topMarks = -1;
            string topper = "None";

            for (int i = 0; i < students.Count; i++)
            {
                Student s = students[i];

                if (marks.ContainsKey(s.RollNo) && marks[s.RollNo].Count > subject)
                {
                    int currentMark = marks[s.RollNo][subject];

                    if (currentMark > topMarks)
                    {
                        topMarks = currentMark;
                        topper = s.Name;
                    }
                }
            }

            Console.WriteLine("Subject " + (subject + 1) + ": " + topper + " (" + topMarks + ")");
        }
    }

    // 4 Remove students failed in 3 exams
    public void RemoveFailedStudents()
    {
        List<Student> removeList = new List<Student>();

        for (int i = 0; i < students.Count; i++)
        {
            Student s = students[i];

            if (!marks.ContainsKey(s.RollNo)) continue;

            int failCount = 0;

            for (int j = 0; j < marks[s.RollNo].Count; j++)
            {
                if (marks[s.RollNo][j] < 30)
                    failCount++;
            }

            if (failCount >= 3)
                removeList.Add(s);
        }

        for (int i = 0; i < removeList.Count; i++)
        {
            students.Remove(removeList[i]);
            marks.Remove(removeList[i].RollNo);
        }

        Console.WriteLine("\nStudents failed in 3 exams removed.");
    }

    public void DisplayAllStudents()
    {
        Console.WriteLine("\nRemaining Students:");

        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine(students[i].Name + " - Roll " + students[i].RollNo);
        }
    }
}
