using System;
using System.Collections.Generic;
using System.Text;

namespace HandsIterativeStatments
{
    class Demo4
    {
        static void Main()
        {
            Console.WriteLine("Enter no");

            int no = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Even or Odd\n2.Natural No's\n3.Multiplication Table\n4.Exit");
                Console.WriteLine("Enter Choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine(no % 2 == 0 ? "Even" : "Odd");
                        }
                        break;
                    case 2:
                        {
                            int flag = 1;
                            while (flag <= no)
                            {
                                Console.WriteLine(flag);
                                flag++;
                            }
                        }
                        break;
                    case 3:
                        {
                            for (int i = 1; i <= 10; i++)
                            {
                                Console.WriteLine("{0}*{1}={2}", no, i, (no * 1));
                            }
                        }
                        break;
                    case 4:
                        Environment.Exit(0); //exit application
                        break;
                    default:
                        Console.WriteLine("Pls Enter values between 1 to 4");
                        break;
                }

            } while (true);
        }
    }
}
