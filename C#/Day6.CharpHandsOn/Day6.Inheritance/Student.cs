using System;
using System.Collections.Generic;
using System.Text;

namespace Day6.Inheritance
{
    class Student
    {
        public int Sid { get; set; } //automatic properties
        public string Sname { get; set; }
        public DateTime DOB { get; set; }
    }
    class Info:Student
    {
        public DateTime EnrollDate { get; set; }
        public void Display()
        {
            Console.WriteLine("ID: " + Sid);
            Console.WriteLine("Name: " + Sname);
            Console.WriteLine("DOB: " + string.Format("{0:D}", DOB));
            Console.WriteLine("EnrollDate: " + string.Format("{0:d}",EnrollDate));
        }
    }
    class App
    {
        static void Main()
        {
            Info obj = new Info() { Sid = 1, 
                Sname = "Rohan", 
                DOB = DateTime.Parse("12.2.2010"), 
                EnrollDate = DateTime.Now };
            obj.Display();
        }
    }

}
