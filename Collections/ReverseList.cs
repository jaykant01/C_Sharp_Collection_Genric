using System.Collections;

namespace Collections;

public class ReverseList
{
    public void Reversee()
    {
        ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Without Built-in Method
        for(int i=list.Count-1; i>=0; i--)
        {
            System.Console.Write(list[i] + " ");
        }
    }


}
