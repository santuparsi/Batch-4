using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnCSharp.Strings
{
    class Demo3
    {
        static void Main()
        {
            // string s = "Hello User";
            // char ch = s[1];
            // string s2=null;
            //for(int i=s.Length-1;i>=0;i--)
            // {
            //     s2 += s[i];
            // }
            // Console.WriteLine("Reverse of {0} is {1}", s, s2);
            double salary = 432093;
            decimal d1 = 234.340329039M;
            DateTime dt = DateTime.Now;//retuns system date & time
            string date = string.Format("{0:D}", dt);
            Console.WriteLine(string.Format("{0:C}", salary));
            Console.WriteLine(string.Format("{0:F2}", d1));
            Console.WriteLine(dt);
            Console.WriteLine(string.Format("{0:D}", dt));
            Console.WriteLine(string.Format("{0:d}", dt));
            Console.WriteLine(string.Format("{0:T}", dt));
            Console.WriteLine(string.Format("{0:t}", dt));


        }
    }
}
