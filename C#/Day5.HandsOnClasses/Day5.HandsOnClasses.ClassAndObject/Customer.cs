using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.HandsOnClasses.ClassAndObject
{
    class Customer
    {
        //class-memebers
        //variables
        public int cId;
        public string cName;
        public string cAdress;
        public void Display()
        {
            Console.WriteLine("ID:" + cId);
            Console.WriteLine("Name: " + cName);
            Console.WriteLine("Adderss: " + cAdress);
        }
    }
}
