using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HandsOnLinq
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }
    class Test
    {
        static void Main()
        {
            List<Student> list = new List<Student>()
            {
                new Student(){Sid=1,Sname="Rohan",Age=10},
                new Student(){Sid=2,Sname="Charan",Age=10},
                new Student(){Sid=3,Sname="Hari",Age=11},
                new Student(){Sid=4,Sname="Karan",Age=10},
                new Student(){Sid=5,Sname="Sruen",Age=11},
                new Student(){Sid=6,Sname="Mohan",Age=10},
            };
            List<Student> l1 = list.Where(i => i.Age == 10).ToList();
            l1 = (from i in list where i.Age == 10 select i).ToList();
            Student s = list.SingleOrDefault(i => i.Sid == 1);
            List<Student> l2 = list.OrderBy(i => i.Sname).ToList();
        }
    }

}
