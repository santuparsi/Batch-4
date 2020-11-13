using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.HandsOnClasses.ClassAndObject
{
    class Product
    {
        public int pId;
        public string pName;
        public double price;
        public DateTime orderDate;
    }
    class Info
    {
        public void Display(Product obj)
        {
            Console.WriteLine("ID: " + obj.pId);
            Console.WriteLine("Name: " + obj.pName);
            Console.WriteLine("Price: " + obj.price);
            Console.WriteLine("OrderDate: " + obj.orderDate.ToShortDateString());
        }
    }
    class App
    {
        static void Main()
        {
            Product[] list = new Product[3];
            for(int i=0;i<3;i++)
            {
                list[i] = new Product();
                Console.WriteLine("Enter Product{0} Details", i+1);
                Console.Write("Enter ID:");
                list[i].pId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name:");
                list[i].pName = Console.ReadLine();
                Console.Write("Enter Price:");
                list[i].price =int.Parse(Console.ReadLine());
                list[i].orderDate = DateTime.Now;

            }
            Info obj = new Info();
            foreach(Product p in list)
            {
                obj.Display(p);
            }
        }
    }


}
