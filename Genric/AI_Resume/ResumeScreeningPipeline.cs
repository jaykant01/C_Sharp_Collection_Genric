namespace AI_Resume;

public class ResumeScreeningPipeline
{
    public static void ProcessResumes<T>(
        List<Resume<T>> resumes)
        where T : JobRole, new()
    {
        foreach (var resume in resumes)
        {
            bool result = resume.Screen();
            Console.WriteLine(
                $"{resume.Data.CandidateName} " +
                $"for {typeof(T).Name}: {result}");
        }
    }
}
