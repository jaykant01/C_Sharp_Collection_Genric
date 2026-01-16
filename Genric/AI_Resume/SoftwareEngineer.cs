namespace AI_Resume;

public class SoftwareEngineer : JobRole
{
    public override string RoleName
    {
        get { return "Software Engineer"; }
    }

    public override bool IsEligible(ResumeData resume)
    {
        return resume.YearsOfExperience >= 2 &&
               resume.Skills.Contains("C#");
    }
}
