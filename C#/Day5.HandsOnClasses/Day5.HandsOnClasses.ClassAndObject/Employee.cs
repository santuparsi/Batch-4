using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.HandsOnClasses.ClassAndObject
{
    class Employee
    {
        public int eId;
        public string eName;
        public double salary;
        public static string Company;
        public static double bonous;
    }
    class Summery
    {
        public void Display(Employee e)
        {
            Console.WriteLine("Company: " + Employee.Company);
            Console.WriteLine("ID: " + e.eId);
            Console.WriteLine("Name: " + e.eName);
            Console.WriteLine("Salary: " + e.salary);
            Console.WriteLine("Bonous: " + Employee.bonous);
        }
    }

    class Test_Employee
    {
        static void Main()
        {
            Employee.Company = "ABC";
            Employee.bonous = 2000;
            Employee[] list = new Employee[2];
            list[0] = new Employee() { eId = 1000, eName = "Rohan", salary = 12000 };
            list[1] = new Employee() { eId = 1002, eName = "Suren", salary = 23000 };
            Summery s = new Summery();
            foreach (Employee e in list)
                s.Display(e);
        }
    }
}
