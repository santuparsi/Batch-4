using System;

namespace Day5.HandsOnClasses.ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer C1 = new Customer();
            C1.cId = 100;
            C1.cName = "Rahul";
            C1.cAdress = "T-Nager,Chennai";
           // C1.Display();
            Customer C2 = new Customer();
            C2.cId = 101;
            C2.cName = "Joy";
            C2.cAdress = "BTM-Layout,Banglore";
            //C2.Display();
            Customer C3 = new Customer();
            // C3.Display();

            //Customer Array
            Customer[] list = new Customer[3] { C1, C2, C3 };
            foreach(Customer c in list)
            {
                c.Display();
                Console.WriteLine("----------------");
            }
        }
    }
}
