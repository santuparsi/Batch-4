using System;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array declaration
            int[] a = new int[4];
            //assign values
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            //access value from an array
            int k = a[1];
            //access all the values(print array values)
            for(int i=0;i<4;i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
            //using for-each to fetch array 
           
            foreach(int n in a)
            {
                Console.Write(n+" ");
            }
            int sum = 0;
            foreach(var m in a)
            {
                sum = sum + m;
            }

            Console.WriteLine("Sum or Array no's {0}",sum);
            Console.ReadKey();
        }
    }
}
