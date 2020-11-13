using System;
using System.Security.Cryptography;

namespace Day5.HandsOnConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(2, 4);
            Rectangle r3 = new Rectangle(3, 6);
            Rectangle r4 = new Rectangle(r2);
            Rectangle r5 = new Rectangle(r3);
            Rectangle[] list = new Rectangle[5] { r1, r2, r3,r4,r5 };
            foreach (Rectangle r in list)
            {
                int area = r.Area();
                Console.WriteLine("Area of Rectangle:" + area);
            }
        }
    }
}
