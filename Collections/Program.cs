using System.Collections;
namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        // List Interface Problems

        // Problem 1
        ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };

        ReverseList reverseList = new ReverseList();
        reverseList.Reverse(list);

        System.Console.WriteLine();

        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        linkedList.AddLast(4);
        linkedList.AddLast(5);

        Console.WriteLine("Original LinkedList:");
        foreach (int item in linkedList)
        {
            Console.Write(item + " ");
        }     
        Console.WriteLine();

        LinkedList<int> reversed = ReverseLinkedList.Reverse(linkedList);

        Console.WriteLine("Reversed LinkedList:");
        foreach (int item in reversed)
        {
            Console.Write(item + " ");
        }

        Console.ReadKey();
                
    }
}
