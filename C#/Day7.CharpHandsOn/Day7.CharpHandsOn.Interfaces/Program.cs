using System;

namespace Day7.CharpHandsOn.Interfaces
{
    interface IShape
    {
        void Area();
        int Points
        {
            get;
            set;
        }
    }
    class Rectangle : IShape
    {
        private int Point;
        public int Points { get =>  Point; set => Point = value; }

        public void Area()
        {
            //Write Functionality for Area of Rectalge
        }
    }
    class Circle : IShape
    {
        private int Point;
        public int Points { get => Point; set => Point = value; }

        public void Area()
        {
            //Write Functionality for Area of Circle
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IShape circle = new Circle(); //access only interface members
            circle.Points = 2;
            circle.Area();
            Rectangle rectangle = new Rectangle(); //access all members of class including interface members.
        }
    }
}
