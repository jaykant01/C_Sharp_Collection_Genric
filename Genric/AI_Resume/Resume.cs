namespace AI_Resume;

public class Resume<T> where T : JobRole, new()
{
    public ResumeData Data { get; set; }
    private T jobRole;

    public Resume(ResumeData data)
    {
        Data = data;
        jobRole = new T();
    }

    public bool Screen()
    {
        return jobRole.IsEligible(Data);
    }
}
