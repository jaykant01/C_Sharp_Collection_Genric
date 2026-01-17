namespace Library;

public class IssueRecord
{
    public string BookName;
    public DateTime DueDate;
    public DateTime ReturnDate;

    public IssueRecord(string bookName, DateTime dueDate, DateTime returnDate)
    {
        BookName = bookName;
        DueDate = dueDate;
        ReturnDate = returnDate;
    }
}
