namespace Collections;

public class InsurancePolicy
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public override bool Equals(object obj)
    {
        return obj is InsurancePolicy policy &&
               PolicyNumber == policy.PolicyNumber;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }
}
