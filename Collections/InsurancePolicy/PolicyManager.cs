using System;
using System.Collections.Generic;

namespace Collections;

public class PolicyManager
{
    private HashSet<InsurancePolicy> policies = new HashSet<InsurancePolicy>();
    private List<InsurancePolicy> insertionOrder = new List<InsurancePolicy>();
    private SortedSet<InsurancePolicy> sortedPolicies =
        new SortedSet<InsurancePolicy>(Comparer<InsurancePolicy>.Create(
            (a, b) => a.ExpiryDate.CompareTo(b.ExpiryDate)));

    public void AddPolicy(InsurancePolicy policy)
    {
        if (policies.Add(policy))
        {
            insertionOrder.Add(policy);
            sortedPolicies.Add(policy);
        }
    }

    public void ShowAllPolicies()
    {
        foreach (var p in policies)
            Console.WriteLine(p.PolicyNumber);
    }

    public void ShowExpiringSoon()
    {
        DateTime limit = DateTime.Now.AddDays(30);
        foreach (var p in sortedPolicies)
        {
            if (p.ExpiryDate <= limit)
                Console.WriteLine(p.PolicyNumber);
        }
    }

    public void ShowByCoverage(string coverage)
    {
        foreach (var p in policies)
        {
            if (p.CoverageType == coverage)
                Console.WriteLine(p.PolicyNumber);
        }
    }
}
