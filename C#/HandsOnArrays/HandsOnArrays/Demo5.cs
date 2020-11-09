//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HandsOnArrays
//{
//    class Demo4
//    {
//        static void Main()
//        {
//            int[,] n = { { 12, 23 }, { 23, 34 }, { 45, 56 } };
//            string[,] login =
//            {
//                {"Rohan","12345"},
//                {"Sachin","12345"},
//                {"Jeson","12345"},
//                {"Suren","12345"},
//                {"Monica","12345"},
//            };
//            Console.WriteLine("enter your name and password");
//            string name = Console.ReadLine();
//            string pwd = Console.ReadLine();
//            int flag = 0;
//            for(int i=0;i<5;i++)
//            {
//                if(login[i,0]==name && login[i,1]==pwd)
//                {
//                    flag = 1;
//                    break;
//                }
//            }
//            if (flag == 1)
//                Console.WriteLine("Valid Login");
//            else
//                Console.WriteLine("Invalid Login");
//        }
//    }
//}
