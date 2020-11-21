using System;
using System.Collections.Generic;
using System.Text;

namespace Day10.HandsOnDelegates
{
    public delegate int CalculateDelegate(int i);
    class Demo2
    {
        public int Cube(int i)
        {
            return i * i * i;
        }
        public void DoIt(CalculateDelegate ob)
        {
            Console.WriteLine(ob(4));
        }
        static void Main()
        {
            Demo2 d2 = new Demo2();
            d2.DoIt(d2.Cube);
            d2.DoIt(n => n * n * n);
        }
    }
}
