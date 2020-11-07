using System;

namespace HandsOnConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a value");
            int a;
            a = int.Parse(Console.ReadLine()); //Reads value from input
            if(a>0)
            {
                Console.WriteLine("{0} is +Ve", a);
            }
            else
            {
                Console.WriteLine("{0} is -Ve", a);
            }
        }
    }
}
