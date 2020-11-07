using System;
using System.Collections.Generic;
using System.Text;

namespace HandsIterativeStatments
{
    class Demo1
    {
        static void Main()
        {
            //do-while
            string name = "Sachin";
            int flag = 1;
            //do
            //{
            //    Console.WriteLine("Hello " + name);
            //    flag++;
            //} while (flag <= 10);
            do
            {
                Console.WriteLine("Hello " + name);
                flag++;
                if (flag == 10)
                    break;
            } while (true);
        }
    }
}
