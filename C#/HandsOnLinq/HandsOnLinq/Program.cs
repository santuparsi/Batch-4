using System;
using System.Linq;
namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 34, 54, 56, 67, 76, 65, 43, 33, 32, 21 };
            //fetch all array values
            var query = from i in a select i;
            query = a.Select(i => i);
            //fetch even values from array
            query = from i in a where i % 2 == 0 select i;
            query = a.Where(i => i % 2 == 0);
            //fetch even values <50
            query = from i in a where i % 2 == 0 && i < 50 select i;
            query = a.Where(i => i % 2 == 0 && i < 50);
            //sorting data
            query = from i in a
                    where i%2==0
                    orderby i descending  select i;
            query = a.Where(i=>i%2==0).OrderByDescending(i => i);
            foreach(var k in query)
            {
                Console.WriteLine(k);
            }
              
        }
    }
}
