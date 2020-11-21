using System;

namespace Day10.HandsOnDelegates
{
    public delegate void Delegate1();
    public delegate void Delegate2(string name);

    class Program
    {
        public void M()
        {
            Console.WriteLine("Hello world...");
        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void Main(string[] args)
        {
            //instantiate delegate
            Delegate1 d1 = new Delegate1(new Program().M);
            //invoke delegate
            d1();
            // Console.WriteLine("Hello World!");
            Delegate2 d2 = new Delegate2(new Program().Greet);
            d2("Sachin");
            Console.ReadKey();
        }
    }
}
