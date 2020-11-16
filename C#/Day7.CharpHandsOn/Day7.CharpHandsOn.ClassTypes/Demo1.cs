using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.CharpHandsOn.ClassTypes
{
    abstract class Shape
    {
        public abstract double Area();
        public void Type()
        {
            Console.WriteLine("It is a 2d shape");
        }
    }
    class Circle : Shape
    {
        public override double Area()
        {
            //write area functinality of Circle
            return 0.0;
        }
    }
    class Rectangle:Shape
    {
        public override double Area()
        {
            //write area of Rectangle
            return 0;
        }
    }


    class Demo1
    {
        static void Main()
        {
            Shape circle = new Circle();
            circle.Area(); //Invoke Circle Area()
            circle.Type(); //Invoke Shape Type();
            Shape rectangle = new Rectangle();
            rectangle.Area(); //Invoke Rectangle Area();
            rectangle.Type();
        }
    }
}
