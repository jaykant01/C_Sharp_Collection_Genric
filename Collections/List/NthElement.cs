using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace Collections;

public class NthElement
{
    public void Element()
    {
        LinkedList<char> ll = new LinkedList<char>();
        ll.AddLast('A');
        ll.AddLast('B');
        ll.AddLast('C');
        ll.AddLast('D');
        ll.AddLast('E');

        if (ll.First == null)
        {
            System.Console.WriteLine("List is empty");
            return;
        }

        int n = 2;
        LinkedListNode<char>? fast = ll.First;
        LinkedListNode<char>? slow = ll.First;

        // Move fast pointer n steps ahead
        for (int i = 0; i < n; i++)
        {
            if (fast == null)
            {
                System.Console.WriteLine("N is greater than number of nodes");
                return;
            }
            fast = fast.Next;
        }

        // Move both pointers
        while (fast != null)
        {
            fast = fast.Next;
            slow = slow.Next;
        }

        System.Console.WriteLine(slow.Value); 
        
    }
    
}
