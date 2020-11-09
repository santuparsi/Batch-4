using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnArrays
{
    class Demo2
    {
        static void Main()
        {
            string[] names = new string[5]
            {
                "Rohan",
                "Karan",
                "Jeson",
                "Monica",
                "Joy"
            };
            Console.WriteLine("Enter a value");
            string name = Console.ReadLine();
            bool flag = false;
            foreach(var k in names)
            {
                if(name==k)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                Console.WriteLine("Valid User..");
            else
                Console.WriteLine("Invalid User..");
            Console.ReadKey();
        }
    }
}
