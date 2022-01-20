using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public void Greet()
        { 
            Console.WriteLine("Animal Says Hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal Talk");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal Song");
        }
    }
    class Dog: Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor");
        }
        public override void Sing()
        {
            Console.WriteLine("Dog Song");
        }
    };
}
