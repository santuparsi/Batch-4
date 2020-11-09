using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnArrays
{
    class Demo3
    {
        static void Main()
        {
            //use built in array class functions
            int[] n = { 12, 3, 56, 54, 43, 6, 7, 8, 89, 90 };
            //display array values in sorted order
            // Array.Sort(n);
            //display array values in reverse order
            //Array.Reverse(n);
            //copy array values
            int[] m = new int[5];
            Array.Copy(n, m, 5);
            //foreach (var k in m)
            //    Console.WriteLine(k);
            int size = n.Length; //retuns size of the array;
            int rank = n.Rank; //return dimension of the arrray(1)
            Console.WriteLine("Size:{0} Rank:{1}", size, rank);
            //using BinarySerach() to search a value in array
            Array.Sort(n);
            if (Array.BinarySearch(n, 90) >= 0)
            {
                Console.WriteLine("Valid No");
            }
            else
                Console.WriteLine("Invalid No");
           
        }
    }
}
