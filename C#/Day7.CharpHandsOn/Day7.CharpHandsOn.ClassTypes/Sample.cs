using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.CharpHandsOn.ClassTypes
{
    class Sample <T>
    {
        //generic-variable
        public T a;
        public T b;
        public int c; //non-generic varaible
        public void Accept(T m,T n)
        {
            a = m;
            b = n;
            Console.WriteLine("{0} {1}");
        }
    }
    class Test
    {
        public static void M<T>(T a,T b) //generic method
        {
           
        }
    }
    class Test_Sample
    {
        static void Main()
        {
            Sample<int> s1 = new Sample<int>();
            s1.a = 10;
            s1.b = 20;
            Sample<string> s2 = new Sample<string>();
            s2.a = "ABCD";
            s2.b = "BCC";
            Sample<char> s3 = new Sample<char>();
            s3.a = 'a';
            Test.M<int>(2, 3);
            Test.M<char>('a', 'b');
            Test.M<double>(12.3, 34.5);
        }
    }

}
