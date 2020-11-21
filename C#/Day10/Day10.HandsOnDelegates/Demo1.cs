using System;
using System.Collections.Generic;
using System.Text;

namespace Day10.HandsOnDelegates
{
    public delegate void MyDelegate(string name);
    class Sample
    {
        public string msg;
        public void ToDo(MyDelegate d)
        {
            d("Sachin");
        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }

    class Demo1
    {
        static void Main()
        {
            Sample s1 = new Sample();
            s1.ToDo(s1.Greet);
            Console.WriteLine(s1.msg);
           
        }
    }
}
