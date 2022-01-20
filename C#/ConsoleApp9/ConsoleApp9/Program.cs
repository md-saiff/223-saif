using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstract a = new AbsDerived();
            int t = a.AddTwoNumbers(4, 5);
            int t1 = a.MultiplyTwoNumbers(4, 5);
            Console.WriteLine("The add of two number is : " + t);
            Console.WriteLine("The Multiply of two number is : " + t1);
        }
    }
}
