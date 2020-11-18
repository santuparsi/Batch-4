using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Day7.HandsOnCollections.NonGeneric
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }

    class Demo1
    {
        static void Main()
        {
            ArrayList ar = new ArrayList() { 12, 23, 34, 45, 56, 67 };
            ArrayList list = new ArrayList()
            {
                new Student(){Sid=1,Sname="Rohan",Age=10},
                new Student(){Sid=2,Sname="Karan",Age=10},
                new Student(){Sid=3,Sname="Charan",Age=10},
                new Student(){Sid=4,Sname="Jeson",Age=10},
                new Student(){Sid=5,Sname="Monica",Age=10},
                new Student(){Sid=6,Sname="Joy",Age=10},
            };
            Student s = list[1] as Student;
            list.Remove(s);
            foreach(Student k in list)
            {
                Console.WriteLine("{0} {1} {2}", k.Sid, k.Sname, k.Age);
            }
        }
    }
}
