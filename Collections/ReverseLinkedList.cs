using System.Collections.Generic;

namespace Collections;

public class ReverseLinkedList
{
    public static LinkedList<int> Reverse(LinkedList<int> list)
    {
        LinkedList<int> reversed = new LinkedList<int>();

        foreach( int item in list)
        {
            reversed.AddFirst(item);
        }

        return reversed;
    }
}
