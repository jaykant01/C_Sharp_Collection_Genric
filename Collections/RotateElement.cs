using System.Collections.Generic;
namespace Collections;

public class RotateElement
{
    public void Rotate()
    {
        List<int> list = new List<int> () {10,20,30,40,50};
        int k = Convert.ToInt32(Console.ReadLine());

        Reverse(list, 0, k-1);
        Reverse(list, k, list.Count-1);
        Reverse(list, 0, list.Count-1);

        foreach(int item in list)
        {
            System.Console.Write(item + " ");
        }
    }

    public void Reverse(List<int> list, int st, int end)
    {
        while(st <= end)
        {
            int temp = list[st];
            list[st] = list[end];
            list[end] = temp;

            st++;
            end--;
        }
    }
    
}
