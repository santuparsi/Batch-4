using System;

namespace Day8.HandsOnCSharp.Polymarphisam
{
    class Employee
    {
        public int eId;
        public string eName;
        public double salary;
        public string designation;
        public Employee(int id,string name,double sal,string desig)
        {
            eId = id;
            eName = name;
            salary = sal;
            designation = desig;
        }
        public virtual void Details()
        {
            Console.WriteLine("ID: " + eId);
            Console.WriteLine("Name: " + eName);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Designation: " + designation);
        }
    }
    class Manager : Employee
    {
        public string[] projects = new string[2];
        public Manager(int id, string name, double sal, string desig,string []projects):base(id,name,sal,desig)
        {
            this.projects = projects;
        }
        public override void Details()
        {
            base.Details();
            Console.WriteLine("Projects Handling: ");
            foreach(var k in projects)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee employee;
            string type = Console.ReadLine();
            if (type == "Programmer")
            {
                employee= new Employee(100, "Rohan", 12000, "Programmer");
                employee.Details();
            }
            Console.WriteLine("--------------------------------");
            if (type == "Manager")
            {
                employee = new Manager(1002, "Karan", 45000, "Project-Manager", new string[] { "E-Commerce", "Baning" });
                employee.Details();
            }
            
        }
    }
}
