using System;
using System.Collections.Generic;
namespace EmployeeLeave;

public class LeaveManager
{
    private Dictionary<int, List<Leave>> employeeLeaves =
        new Dictionary<int, List<Leave>>();

    private HashSet<DateTime> holidays = new HashSet<DateTime>();

    private const int MAX_CASUAL_LEAVES = 12;

    // Add holiday
    public void AddHoliday(DateTime date)
    {
        holidays.Add(date.Date);
    }

    // Apply leave
    public void ApplyLeave(int empId, Leave newLeave)
    {
        if (!employeeLeaves.ContainsKey(empId))
            employeeLeaves[empId] = new List<Leave>();

        if (IsOverlapping(empId, newLeave))
        {
            Console.WriteLine("Leave rejected: Overlapping leave.");
            return;
        }

        int leaveDays = CountValidLeaveDays(newLeave);

        if (leaveDays > 2)
        {
            Console.WriteLine("Leave rejected: More than 2 consecutive leaves.");
            return;
        }

        int yearlyLeaves = GetYearlyLeaveCount(empId, newLeave.StartDate.Year);

        if (yearlyLeaves + leaveDays > MAX_CASUAL_LEAVES)
        {
            Console.WriteLine("Leave rejected: Exceeds yearly leave limit.");
            return;
        }

        employeeLeaves[empId].Add(newLeave);
        Console.WriteLine("Leave approved.");
    }

    // Count leave days excluding holidays
    private int CountValidLeaveDays(Leave leave)
    {
        int count = 0;
        DateTime date = leave.StartDate;

        while (date <= leave.EndDate)
        {
            if (!holidays.Contains(date.Date))
                count++;

            date = date.AddDays(1);
        }
        return count;
    }

    // Overlapping leave check
    private bool IsOverlapping(int empId, Leave newLeave)
    {
        List<Leave> leaves = employeeLeaves[empId];

        for (int i = 0; i < leaves.Count; i++)
        {
            Leave existing = leaves[i];

            if (!(newLeave.EndDate < existing.StartDate ||
                  newLeave.StartDate > existing.EndDate))
            {
                return true;
            }
        }
        return false;
    }

    // Yearly leave count (handles year-end cases)
    private int GetYearlyLeaveCount(int empId, int year)
    {
        int count = 0;

        if (!employeeLeaves.ContainsKey(empId))
            return 0;

        List<Leave> leaves = employeeLeaves[empId];

        for (int i = 0; i < leaves.Count; i++)
        {
            DateTime date = leaves[i].StartDate;

            while (date <= leaves[i].EndDate)
            {
                if (date.Year == year && !holidays.Contains(date.Date))
                    count++;

                date = date.AddDays(1);
            }
        }
        return count;
    }

    // Leave balance report
    public void GenerateLeaveReport(int empId)
    {
        int used = GetYearlyLeaveCount(empId, DateTime.Now.Year);
        int remaining = MAX_CASUAL_LEAVES - used;

        Console.WriteLine("\nLeave Report for Employee " + empId);
        Console.WriteLine("Used Leaves: " + used);
        Console.WriteLine("Remaining Leaves: " + remaining);
    }
}
