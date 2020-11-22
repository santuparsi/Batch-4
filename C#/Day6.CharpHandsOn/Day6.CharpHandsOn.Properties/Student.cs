using System;
using System.Collections.Generic;
using System.Text;

namespace Day6.CharpHandsOn.Properties
{
    class Student
    {
        private int sId;
        private string sName;
        private static int std;
        //prop for sId
        public int SID
        {
            get { return sId; }
            set { sId = value; }
        }
        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }
        public static int STD
        {
            get { return std; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    std = value;
                }
                else
                    Console.WriteLine("Invalid Std");
            }
        }


    }
    class Enroll
    {
        public Student[] list = new Student[3];
        int count = 0;
        public void Register(Student s)
        {
            if (count < list.Length)
            {
                list[count] = s;
                count++;
            }
            else
            {
                Console.WriteLine("Registration full..");
            }
        }
        public Student [] GetStudents()
        {
            return list;
        }
    }

    class Info
    {
        public static void Display(Student s)
        {
            Console.WriteLine("ID: " + s.SID); //get accessor inovke
            Console.WriteLine("Name: " + s.SName);
            Console.WriteLine("Class: " + Student.STD);
               
        }
    }
    class App
    {
        static void Main()
        {
            Student.STD = 2;
            Student s2 = new Student() { SID = 1, SName = "Rohan" };
            Student s1 = new Student() { SID = 2, SName = "Suren" };
            Enroll obj = new Enroll();
            obj.Register(s1);
            obj.Register(s2);
            foreach(Student s in obj.GetStudents())
            {
                if(s!=null)
                Info.Display(s);
            }
        }
    }


}
