using System;
using System.Collections.Generic;
using System.Text;

namespace Day6.Inheritance
{
    class A
    {
        public  A()
        {
            Console.WriteLine("A Consturctor");
        }
        public A(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public A(string name,int age)
        {
            Console.WriteLine("Hello {0} you are {1} ");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("B Constructor");
        }
        //public B():base("Sachin")
        //{
        //    Console.WriteLine("B Constructor");
        //}
        public B(string name):base(name)
        {

        }
        public B(string name,int age):base(name,age)
        {

        }
    }


    class Demo1
    {
        static void Main()
        {
            B obj = new B();
            B obj1 = new B("Sachin");
            B obj2 = new B("Sachin",12);
        }
    }
}
