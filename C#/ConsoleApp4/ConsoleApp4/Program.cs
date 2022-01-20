using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator calc = new calculator();
            int result = calc.Add(6, 4);
            int result1 = calc.Sub(6, 4);
            int result2 = calc.Mul(6, 4);
            float result3 = calc.Div(6, 4);
            Console.WriteLine("Addition Of Two Number Is "+result);
            Console.WriteLine("Subtraction Of Two Number Is "+result1);
            Console.WriteLine("Multiplication Of Two Number Is "+result2);
            Console.WriteLine("Division Of Two Number Is "+result3);

        }
    }
}
