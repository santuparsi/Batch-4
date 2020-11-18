using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Day7.HandsOnCollections.NonGeneric
{
    class Demo2
    {
        static void Main()
        {
            //Hashtable ob = new Hashtable();
            SortedList ob = new SortedList();
            ob.Add(1002, "Rohan");
            ob.Add(1200, "Charan");
            ob.Add(1000, "Suren");
            ob.Add(1001, "Monica");
            string s = ob[1000].ToString();
            ob.Remove(1200);//removes Charan
            foreach(var k in ob.Keys)
            {
                Console.WriteLine("{0} {1}", k, ob[k]);
            }
        }
    }
}
