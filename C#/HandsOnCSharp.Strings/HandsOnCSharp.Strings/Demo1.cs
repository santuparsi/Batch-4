using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnCSharp.Strings
{
    class Demo1
    {
        static void Main()
        {
            string s1 = "abcd";
            string s2 = "ABCD";
            string s3 = s1 + s2;
            if(s1==s2)
            {
                Console.WriteLine("equal");
            }
            if(string.Compare(s1,s2)==0)
            {
                Console.WriteLine("equal");
            }
            if (string.Compare(s1, s2,true) == 0) //ignore case
            {
                Console.WriteLine("equal");
            }
            if (s1.Equals(s2))
            {
                Console.WriteLine("equal");
            }
            if (s1.Equals(s2,StringComparison.OrdinalIgnoreCase)) //ignore case
            {
                Console.WriteLine("equal");
            }
        }
    }
}
