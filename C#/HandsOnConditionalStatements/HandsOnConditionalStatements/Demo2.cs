using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnConditionalStatements
{
    class Demo2
    {
        static void Main()
        {
            double m1 = 18, m2 = 17, m3 = 16;
            double tot = m1 + m2 + m3;
            double avg = tot / 3;
            if(avg>=70)
            {
                Console.WriteLine("Result:Distinction % is {0} Marks {1}", avg, tot);
            }
            else if(avg>=60 &&avg<70)
            {
                Console.WriteLine("Result:FirstClass % is {0} Marks {1}", avg, tot);
            }
            else if(avg>=50 && avg<60)
            {
                Console.WriteLine("Result:SecondClass % is {0} Marks {1}", avg, tot);
            }
            else if(avg>=40 && avg<50)
            {
                Console.WriteLine("Result:ThirdClass % is {0} Marks {1}", avg, tot);
            }
            else
            {
                Console.WriteLine("Result:Fail");
            }
        }
    }
}
