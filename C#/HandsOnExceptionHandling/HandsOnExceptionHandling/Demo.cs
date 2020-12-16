using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnExceptionHandling
{
    class Demo
    {
        public static void Div(byte a,byte b)
        {
           try
            {
                int c = a / b;
                Console.WriteLine("Divison of {0}/{1} is {2}", a, b, c);
            }
            catch(DivideByZeroException ex)
            {
                //Console.WriteLine("b value should not be zero");
                throw ex;
            }
        }
        public static void Main()
        {
            try
            {
                byte a, b;
                Console.WriteLine("Enter a,b values");
                a = Convert.ToByte(Console.ReadLine());
                b = Convert.ToByte(Console.ReadLine());
                Div(a, b);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Enter only no's");
            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex.Message);
                HandleError.WriteError(new CustomException()
                {
                    Exception=ex,
                    ClassName="Demo",
                    MethodName="DIv"
                });
            }
        }
    }
}
