using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnConditionalStatements
{
    class Demo3
    {
       static void Main()
        {
            int a = 12;
            int b = 13;
            if(a==b)
            {

            }
            else
            {

            }
            bool flag = (a % 2==0) ? true : false;
            string result;
            switch(flag)
            {
                case true:
                    result = "Even";
                    break;
                case false:
                    result = "Odd";
                    break;
                    
            }
            Console.WriteLine(result);
            char ch = '1';
            switch(ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not Vowel");
                    break;
            }
            Console.ReadKey();
        }
    }
}
