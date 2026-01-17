namespace Bank;

public class Transaction
{
    public DateTime Time;
    public double Amount;
    public string Type;

    public Transaction(DateTime time, double amount, string type)
    {
        Time = time;
        Amount = amount;
        Type = type;
    }
}
