using System.Collections;

namespace Collections;

public class ReverseList
{
    public void Reverse(ArrayList list)
    {
        // original list
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Without Built-in Method
        // for(int i=list.Count-1; i>=0; i--)
        // {
        //     System.Console.Write(list[i] + " ");
        // }

        // Without Built-in Method 2
        int st = 0;
        int en = list.Count - 1;
        while (st < en)
        {
            var temp = list[st];
            list[st] = list[en];
            list[en] = temp;
            st++;
            en--;
        }

        // reversed list
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }


}
