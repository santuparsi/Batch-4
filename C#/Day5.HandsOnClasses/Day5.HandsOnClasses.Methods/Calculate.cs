using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.HandsOnClasses.Methods
{
    class Calculate
    {
        public int result;
        public void Add(int a,int b)
        {
            result=a + b;
        }
        public double Sqaure(double a)
        {
            double c;
            c = a * a;
            return c;
        }
        public static string Greet(string name)
        {
            if (name != null)
                return "Hello " + name;
            else
                return "Hello " + " Anonymous";
        }
    }
}
