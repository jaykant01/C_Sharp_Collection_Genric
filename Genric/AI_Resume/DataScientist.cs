namespace AI_Resume;

public class DataScientist : JobRole
{
    public override string RoleName
    {
        get { return "Data Scientist"; }
    }

    public override bool IsEligible(ResumeData resume)
    {
        return resume.YearsOfExperience >= 3 &&
               resume.Skills.Contains("Python");
    }
}
