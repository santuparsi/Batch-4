using System;
using System.Collections;
namespace Day7.HandsOnCollections.NonGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ArrayList ar = new ArrayList();
            //add values
            ar.Add(12);
            ar.Add(12.45);
            ar.Add("Rohan");
            ar.Add(true);
            double d = (double)ar[1];
            foreach(var k  in ar)
            {
                Console.WriteLine(k);
            }
            
        }
    }
}
