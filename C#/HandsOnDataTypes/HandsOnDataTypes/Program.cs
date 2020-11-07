using System;

namespace HandsOnDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable delcaration
            //integer types
            byte b = 10;
            int i = 20;
            short s = 34;
            long l = 34893;
            //decimal types
            double d = 12.345;
            float f = 34.56f;
            decimal d1 = 34.566677m;
            //char types
            char ch = 'r';
            //bool type
            bool flag = true;
            //datetime
            DateTime d2 = DateTime.Now; //current system date and time.

            //reference types
            string s1 = "Hello User";
            object o1 = 12;
           o1 = "ABC"; 
            object o2 = 12.34;
            object o3 = 'a';
            object o4 = "ABCD";

            //var type
            var j = 10;
            var k = "AAA";
            //j = "ABC"; //compile-time error
            // Console.WriteLine("Hello World!");
            Console.WriteLine(d2);
            Console.WriteLine(s1);
            Console.WriteLine(o1);
            Console.Clear();
            int a = 10;
            int b1 = 0;
            int c = a / b1;
            Console.WriteLine(c);
        }
    }
}
