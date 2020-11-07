using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnConditionalStatements
{
    class Demo1
    {
        static void Main()
        {
            //nested-if
            byte a = 10, b= 20, c = 30;
            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("{0} is Grater", a);
                }
                else
                    Console.WriteLine("{0} is Grater", c);
            }
            else
            {
                if(b>c)
                {
                    Console.WriteLine("{0} is Grater", b);
                }
                else
                    Console.WriteLine("{0} is Grater", c);
            }
        }
    }
}
