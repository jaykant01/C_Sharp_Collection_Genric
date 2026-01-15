using Microsoft.VisualBasic;

namespace Collections;

public class RemoveDuplicates
{
    public void Duplicate()
    {
        List<int> list = new List<int>() {3,1,2,2,3,4};
        foreach(int item in list)
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine();

        HashSet<int> hs = new HashSet<int>();

        for(int i=0; i<list.Count; i++)
        {
            if (!hs.Contains(list[i]))
            {
                hs.Add(list[i]);
            }
        }

        foreach(int item in hs)
        {
            System.Console.Write(item + " ");
        }
    }
}
