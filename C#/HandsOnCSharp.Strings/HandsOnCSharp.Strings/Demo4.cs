using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HandsOnCSharp.Strings
{
    class Demo4
    {
        static void Main()
        {
            //string s = "Good Morning";
            //s=s.Replace("Morning", "Evening");
            //Console.WriteLine(s);
            StringBuilder sb = new StringBuilder("Good Morning");
            sb.Append(" Users");
            Console.WriteLine(sb);
            sb.Replace("Morning", "Evening");
            Console.WriteLine(sb);
        }
    }
}
