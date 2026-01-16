namespace AI_Resume;

public abstract class JobRole
{
    public abstract string RoleName { get; }
    public abstract bool IsEligible(ResumeData resume);
}
