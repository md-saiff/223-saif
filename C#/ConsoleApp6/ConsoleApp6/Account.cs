using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Account
    {
        public Account()
        {
            //Console.WriteLine("Animal Constructor");
        }
        public virtual void AccName()
        {
            Console.WriteLine("Current Acc");
        }
       
    }
    class Customer : Account
    {
        public override void AccName()
        {
            Console.WriteLine("Savings Acc");
        }
        
    };
}
