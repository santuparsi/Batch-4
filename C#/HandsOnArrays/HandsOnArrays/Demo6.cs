using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnArrays
{
    class Demo4
    {
        static void Main()
        {
            int[] a1 = new int[3];
            a1[0] = 10;
            //jagged array declaration
            int[][] a = new int[3][];
            a[0] = new int[3] { 12, 23, 34 };
            a[1] = new int[4] { 12, 34, 45, 56 };
            a[2] = new int[2] { 12, 23 };

            //accessing value
            int[] m = a[0];
            foreach(int i in m)
            {
                Console.WriteLine(i);
            }
            for(int k=0;k<3;k++)
            {
                foreach(var i in a[k])
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
