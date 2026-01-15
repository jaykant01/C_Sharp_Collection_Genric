using System.Runtime.InteropServices;

namespace Collections;

public class CheckEqual
{
    public void Equal()
    {
        HashSet<int> hs1 = new HashSet<int>() {1,2,3};
        HashSet<int> hs2 = new HashSet<int>() {3,2,1};

        bool areEqual = hs1.SetEquals(hs2);
        System.Console.WriteLine(areEqual);
    }
}
