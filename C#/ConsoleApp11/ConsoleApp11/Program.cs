using System;
using System.Collections;
namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            // Stack mystack = new Stack();
            //  mystack.Push("Hell0 !");
            //mystack.Push(null);
            //mystack.Push(1);
            // mystack.Push(2);
            //mystack.Push(3);


            Queue myqueue = new Queue();
            myqueue.Enqueue(" Hello !");
            myqueue.Enqueue(1);
            myqueue.Enqueue(2);
            myqueue.Enqueue(3);

            foreach (var item in myqueue)
        {
            Console.WriteLine(item);
        }
        }
    }
}
