using System;
using System.Collections.Generic;
using System.Text;

namespace Day10.HandsOnDelegates
{
    class Demo3
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public string Greet(string name)
        {
            return "Hello " + name;
        }
        public void Note(string name)
        {
            Console.WriteLine("Hi " + name);
        }
        static void Main()
        {
            //invoke add method using delegate
            Func<int, int, int> fn = new Demo3().Add;
            Console.WriteLine(fn(2, 3));
            Func<string, string> fn2 = new Demo3().Greet;
            Console.WriteLine(fn2("Sachin"));
            Action<string> ac1 = new Demo3().Note;
            ac1("Rahul");
        }
    }
}
