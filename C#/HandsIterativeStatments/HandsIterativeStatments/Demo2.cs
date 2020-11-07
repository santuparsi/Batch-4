using System;
using System.Collections.Generic;
using System.Text;

namespace HandsIterativeStatments
{
    class Demo2
    {
        static void Main()
        {
            int n = 5;
            int fact = 1;
            //for loop
            //for(int i=1;i<=n;i++)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine("Fact: " + fact);
            for (int i = n; i>0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Fact: " + fact);
        }
    }
}
