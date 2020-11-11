using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnArrays
{
    class Demo7
    {
        static void Main()
        {
            double[][] d = new double[][]
            {
                new double[]{12.2,34.5,56.7},
                new double[]{34.45,67.8}
            };
            int count = 0;
            for (int i = 0; i < d.Length; i++)
            {
                double sum = 0;
                count++;
                foreach (int k in d[i])
                {
                    sum = sum +k;
                }
                Console.WriteLine("Sum of Array {0}: {1}", count, sum);
            }
        }
    }
}
