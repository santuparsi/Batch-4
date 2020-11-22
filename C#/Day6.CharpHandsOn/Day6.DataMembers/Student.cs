using System;
using System.Collections.Generic;
using System.Text;

namespace Day6.DataMembers
{
    class Student
    {
        public readonly int sId;
        public string sName;
        public static string sClass;
        public const string scholl = "DPS";
        public Student(int id)
        {
            this.sId = id; //set read-only value.
        }
    }
    class Info
    {
        public static void Display(Student s)
        {
            Console.WriteLine("ID: " + s.sId);
            Console.WriteLine("Name: " + s.sName);
            Console.WriteLine("ClassName: " + Student.sClass);
            Console.WriteLine("School: " + Student.scholl);
                
        }
    }
    class APP
    {
        static void Main()
        {
            Student s2 = new Student(10) {sName="Rohan" };
            Student.sClass = "II";
            Student s1 = new Student(12) { sName = "Charan" };
            foreach(Student s in new Student[] { s2,s1})
            {
                Info.Display(s);
            }

            
        }
    }


}
