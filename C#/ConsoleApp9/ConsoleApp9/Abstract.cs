using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    abstract class Abstract
    {
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }

    class AbsDerived : Abstract
    {
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
}
