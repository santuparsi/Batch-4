using System;

namespace HandsOnExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                byte a, b;
                Console.WriteLine("Enter a,b values");
                a = Convert.ToByte(Console.ReadLine());
                b = Convert.ToByte(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("Divison of {0}/{1} is {2}", a, b, c);
               
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("b value should not be 0");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Enter Only no's");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
