using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.CharpHandsOn.ClassTypes
{
    static class Compute
    {
        private static double PI;
        public static int result;
        public static double radius;
        static Compute()
        {
            PI = 3.14;
        }
        public static void Add(int a,int b)
        {
            result = a + b;
        }
        public static double Area()
        {
            //area of circle
            return PI * Math.Pow(radius, 2);
        }
    }
    class Test_Compute
    {
        static void Main()
        {
            Compute.Add(3, 5);
            Console.WriteLine("Add: ", Compute.result);
            Compute.radius = 23.4;
            double r = Compute.Area();
        }
    }

}
