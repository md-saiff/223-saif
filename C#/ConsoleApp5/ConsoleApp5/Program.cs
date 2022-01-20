using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.Greet();
            a.Talk();
            a.Sing();
           
        }
    }
}
