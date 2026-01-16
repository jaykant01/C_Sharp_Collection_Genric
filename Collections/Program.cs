using System.Collections;
namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        // List Interface Problems

        // Problem 1
        // ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };

        // ReverseList reverseList = new ReverseList();
        // reverseList.Reverse(list);

        // System.Console.WriteLine();

        // LinkedList<int> linkedList = new LinkedList<int>();
        // linkedList.AddLast(1);
        // linkedList.AddLast(2);
        // linkedList.AddLast(3);
        // linkedList.AddLast(4);
        // linkedList.AddLast(5);

        // Console.WriteLine("Original LinkedList:");
        // foreach (int item in linkedList)
        // {
        //     Console.Write(item + " ");
        // }     
        // Console.WriteLine();

        // LinkedList<int> reversed = ReverseLinkedList.Reverse(linkedList);

        // Console.WriteLine("Reversed LinkedList:");
        // foreach (int item in reversed)
        // {
        //     Console.Write(item + " ");
        // }

        // Problem 2
        // FindFrequency findFrequency = new FindFrequency();
        // findFrequency.FindFreq();

        // Problem 3
        // RotateElement rotateElement = new RotateElement();
        // rotateElement.Rotate();

        // Problem 4
        // RemoveDuplicates removeDuplicates = new RemoveDuplicates();
        // removeDuplicates.Duplicate();

        // Problem 5
        // NthElement nthElement = new NthElement();
        // nthElement.Element();


        // Set Interface

        // Problem 1
        //CheckEqual checkEqual = new CheckEqual();
        //checkEqual.Equal();


        // Insurance Policy
        //PolicyManager manager = new PolicyManager();

        //manager.AddPolicy(new InsurancePolicy
        //{
        //    PolicyNumber = "P101",
        //    CoverageType = "Health",
        //    ExpiryDate = DateTime.Now.AddDays(10)
        //});

        //manager.AddPolicy(new InsurancePolicy
        //{
        //    PolicyNumber = "P102",
        //    CoverageType = "Life",
        //    ExpiryDate = DateTime.Now.AddDays(40)
        //});

        //manager.AddPolicy(new InsurancePolicy
        //{
        //    PolicyNumber = "P103",
        //    CoverageType = "Vehicle",
        //    ExpiryDate = DateTime.Now.AddDays(20)
        //});

        //Console.WriteLine("All Policies:");
        //manager.ShowAllPolicies();

        //Console.WriteLine("\nExpiring in 30 Days:");
        //manager.ShowExpiringSoon();

        //Console.WriteLine("\nHealth Policies:");
        //manager.ShowByCoverage("Health");


        // Problem Voting System
        VotingSystem voting = new VotingSystem();

        voting.CastVote("Alice");
        voting.CastVote("Bob");
        voting.CastVote("Alice");
        voting.CastVote("Charlie");
        voting.CastVote("Bob");

        voting.ShowVoteOrder();
        Console.WriteLine();
        voting.ShowSortedResults();


        Console.ReadKey();
                
    }
}
