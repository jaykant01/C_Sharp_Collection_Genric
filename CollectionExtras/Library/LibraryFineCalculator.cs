namespace Library;

public class LibraryFineCalculator
{
    private Dictionary<int, List<IssueRecord>> records =
        new Dictionary<int, List<IssueRecord>>();

    private const int MAX_FINE = 500;

    // Add issue record
    public void AddRecord(int studentId, IssueRecord record)
    {
        if (!records.ContainsKey(studentId))
            records[studentId] = new List<IssueRecord>();

        records[studentId].Add(record);
    }

    // Calculate fine for a single record
    public int CalculateFine(IssueRecord record)
    {
        if (record.ReturnDate <= record.DueDate)
            return 0; 

        int fine = 0;
        int lateDays = 0;
        DateTime date = record.DueDate.AddDays(1);

        while (date <= record.ReturnDate)
        {
            if (date.DayOfWeek != DayOfWeek.Sunday)
            {
                lateDays++;

                if (lateDays <= 7)
                    fine += 2;
                else
                    fine += 5;
            }

            if (fine >= MAX_FINE)
                return MAX_FINE;

            date = date.AddDays(1);
        }

        return fine;
    }

    // Monthly fine report
    public void GenerateMonthlyReport(int month, int year)
    {
        Console.WriteLine("\nMonthly Fine Report: " + month + "/" + year);

        foreach (int studentId in records.Keys)
        {
            int totalFine = 0;
            List<IssueRecord> list = records[studentId];

            for (int i = 0; i < list.Count; i++)
            {
                IssueRecord r = list[i];

                if (r.ReturnDate.Month == month && r.ReturnDate.Year == year)
                {
                    totalFine += CalculateFine(r);

                    if (totalFine >= MAX_FINE)
                    {
                        totalFine = MAX_FINE;
                        break;
                    }
                }
            }

            if (totalFine > 0)
                Console.WriteLine("Student " + studentId + " Fine: ₹" + totalFine);
        }
    }

    // Identify frequent defaulters
    public void DisplayFrequentDefaulters()
    {
        Console.WriteLine("\nFrequent Defaulters:");

        foreach (int studentId in records.Keys)
        {
            int lateCount = 0;
            List<IssueRecord> list = records[studentId];

            for (int i = 0; i < list.Count; i++)
            {
                if (CalculateFine(list[i]) > 0)
                    lateCount++;
            }

            if (lateCount >= 3)
                Console.WriteLine("Student " + studentId + "  Late Books: " + lateCount);
        }
    }
}
