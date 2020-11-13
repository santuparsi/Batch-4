using System;

namespace Day5.HandsOnClasses.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Calculate obj = new Calculate();
            obj.Add(12, 23);
            Console.WriteLine(obj.result);
            obj.Add(3, 4);
            double c = obj.Sqaure(23.4);
            Console.WriteLine(Calculate.Greet("Sachin"));
            Console.WriteLine(Calculate.Greet(null));
        }
    }
}
