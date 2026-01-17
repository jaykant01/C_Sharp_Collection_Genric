using System;
using System.Collections.Generic;
namespace Bank;

public class FraudDetector
{
    private Dictionary<long, List<Transaction>> accountTransactions =
        new Dictionary<long, List<Transaction>>();

    private Dictionary<long, double> balances =
        new Dictionary<long, double>();

    private Dictionary<long, bool> flaggedAccounts =
        new Dictionary<long, bool>();

    // Add initial balance
    public void AddAccount(long accountNo, double balance)
    {
        if (balance < 0)
            balance = 0;

        balances[accountNo] = balance;
        accountTransactions[accountNo] = new List<Transaction>();
        flaggedAccounts[accountNo] = false;
    }

    // Process transaction
    public void ProcessTransaction(long accountNo, Transaction txn)
    {
        if (!balances.ContainsKey(accountNo))
            return;

        accountTransactions[accountNo].Add(txn);

        if (txn.Type == "WITHDRAW")
        {
            CheckWithdrawalRules(accountNo, txn);
            balances[accountNo] -= txn.Amount;

            if (balances[accountNo] < 0)
                balances[accountNo] = 0;
        }
        else
        {
            balances[accountNo] += txn.Amount;
        }
    }

    
    private void CheckWithdrawalRules(long accountNo, Transaction txn)
    {
        
        double balance = balances[accountNo];

        if (balance == 0 && txn.Amount > 0)
        {
            FlagAccount(accountNo, "Withdrawal on zero balance");
            return;
        }

        if (txn.Amount > balance * 0.8)
        {
            FlagAccount(accountNo, "Withdrawal exceeds 80% of balance");
        }

        
        Queue<Transaction> recentWithdrawals = new Queue<Transaction>();

        List<Transaction> txns = accountTransactions[accountNo];

        for (int i = 0; i < txns.Count; i++)
        {
            if (txns[i].Type == "WITHDRAW")
            {
                recentWithdrawals.Enqueue(txns[i]);
            }
        }

        
        while (recentWithdrawals.Count > 0)
        {
            Transaction first = recentWithdrawals.Peek();
            double minutesDiff =
                (txn.Time - first.Time).TotalMinutes;

            if (minutesDiff > 10)
                recentWithdrawals.Dequeue();
            else
                break;
        }

        if (recentWithdrawals.Count > 3)
        {
            FlagAccount(accountNo, "More than 3 withdrawals in 10 minutes");
        }
    }

    private void FlagAccount(long accountNo, string reason)
    {
        flaggedAccounts[accountNo] = true;
        Console.WriteLine("Account " + accountNo + " flagged: " + reason);
    }

    
    public void GenerateSuspiciousReport()
    {
        Console.WriteLine("\n Suspicious Transaction Report ");

        foreach (long accountNo in flaggedAccounts.Keys)
        {
            if (flaggedAccounts[accountNo])
            {
                Console.WriteLine("Account: " + accountNo);

                List<Transaction> txns = accountTransactions[accountNo];

                for (int i = 0; i < txns.Count; i++)
                {
                    Transaction t = txns[i];
                    Console.WriteLine(
                        t.Type + "  " +
                        t.Amount + "  " +
                        t.Time);
                }
                Console.WriteLine();
            }
        }
    }
}
