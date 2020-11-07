using System;
using System.Collections.Generic;
using System.Text;

namespace HandsIterativeStatments
{
    class Demo3
    {
        static void Main()
        {
            int i = 1;
            //for(;i<=100;i++)
            //{
            //    Console.Write(i + " ");
            //}
            //for(;i<=100;)
            //{
            //    Console.WriteLine(i + " ");
            //    i++;
            //}
            //for(; ; )
            //{
            //    Console.WriteLine(i + " ");
            //    i++;
            //    if (i == 50)
            //        break;
            //}
            //print odd numbers from 1 to 50
            for(; i<=50;i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
