using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Testdata t = new Testdata();
            int T=t.Add(5,7,6);
            Console.WriteLine(T);
            int T1= t.Add(6,8);
            Console.WriteLine(T1);

        }
    }
}
