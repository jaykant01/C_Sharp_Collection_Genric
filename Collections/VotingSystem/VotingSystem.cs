namespace Collections;

public class VotingSystem
{
    // Stores total votes
    private Dictionary<string, int> votes = new Dictionary<string, int>();

    // Maintains order of votes (LinkedHashMap)
    private List<string> voteOrder = new List<string>();

    public void CastVote(string candidate)
    {
        voteOrder.Add(candidate);  

        if (votes.ContainsKey(candidate))
            votes[candidate]++;
        else
            votes[candidate] = 1;
    }

    // Display votes in insertion order
    public void ShowVoteOrder()
    {
        Console.WriteLine("Vote Order:");
        foreach (var v in voteOrder)
            Console.WriteLine(v);
    }

    // Display final results in sorted order
    public void ShowSortedResults()
    {
        SortedDictionary<string, int> sortedVotes =
            new SortedDictionary<string, int>(votes);

        Console.WriteLine("Sorted Results:");
        foreach (var v in sortedVotes)
            Console.WriteLine(v.Key + " : " + v.Value);
    }
}
