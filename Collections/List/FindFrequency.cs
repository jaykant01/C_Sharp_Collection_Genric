using System.Collections;
using System.Security.Cryptography;

namespace Collections;

public class FindFrequency
{
    public void FindFreq()
    {
        List<string> list = new List<string>() { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> hm = new Dictionary<string, int>();

        for(int i=0; i<list.Count; i++)
        {
            if (hm.ContainsKey(list[i]))
            {
                hm[list[i]]++;
            }
            else
            {
                hm.Add(list[i], 1);
            }
        }

        // print frequency
        foreach(var item in hm)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }   
    } 
}
