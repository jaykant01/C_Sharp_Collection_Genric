namespace Collections;

public class BankingSystem
{
    // Store account balances
    private Dictionary<int, double> accounts = new Dictionary<int, double>();

    // Withdrawal requests queue
    private Queue<int> withdrawalQueue = new Queue<int>();

    // Add account
    public void AddAccount(int accountNumber, double balance)
    {
        accounts[accountNumber] = balance;
    }

    // Request withdrawal
    public void RequestWithdrawal(int accountNumber)
    {
        withdrawalQueue.Enqueue(accountNumber);
    }

    // Process withdrawals
    public void ProcessWithdrawals()
    {
        Console.WriteLine("Processing Withdrawals:");
        while (withdrawalQueue.Count > 0)
        {
            int accNo = withdrawalQueue.Dequeue();
            Console.WriteLine("Withdrawal processed for Account: " + accNo);
        }
    }

    // Display customers sorted by balance
    public void ShowSortedByBalance()
    {
        SortedDictionary<double, int> sorted =
            new SortedDictionary<double, int>();

        foreach (var acc in accounts)
            sorted[acc.Value] = acc.Key;

        Console.WriteLine("Accounts Sorted by Balance:");
        foreach (var acc in sorted)
            Console.WriteLine(acc.Value + " : " + acc.Key);
    }
}
