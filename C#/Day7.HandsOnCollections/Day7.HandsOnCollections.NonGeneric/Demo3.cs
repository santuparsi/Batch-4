using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Day7.HandsOnCollections.NonGeneric
{
    class Demo3
    {
        static void Main()
        {
            //Stack stack = new Stack();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //Console.WriteLine("Top Value: " + stack.Peek()); //returns top value
            //stack.Pop(); //remoes top value
            //foreach (var k in stack)
            //    Console.WriteLine(k);
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            Console.WriteLine("Peak Value: "+queue.Peek()); //returns first value
            queue.Dequeue(); //removes first value
            foreach(var k in queue)
            {
                Console.WriteLine(k);
            }
        }
    }
}
