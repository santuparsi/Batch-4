using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnCSharp.Strings
{
    class Demo2
    {
        static void Main()
        {
            //Split()
            string s = "C#.net Vb.net,Asp.net";
            //string[] str = s.Split(' ');
            //string[] str = s.Split(' ', ',');
            string[] str = s.Split(' ', ',','.');
            //Console.WriteLine(str[0]);
            foreach (var k in str)
                Console.WriteLine(k);
            Console.WriteLine("Enter EmailID");
            string email = Console.ReadLine();
            string[] re = email.Split('@');
            string uname = re[0];
            Console.WriteLine("Username: " + uname);

            //Join
            string s11 = string.Join(' ', "I", "LOVE", "India");
            Console.WriteLine(s11);
        }
    }
}
