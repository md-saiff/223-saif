using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Account obj = new Account();
            Double currentBalance = obj.GetBalance();

            //
            obj.GetBalance = 200000;
        }
    }
}
