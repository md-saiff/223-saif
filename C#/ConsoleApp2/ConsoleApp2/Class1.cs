using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Employee
    {
        public Employee()
        {

        }

        public void GetName()
        {
            Console.WriteLine("Enter Your Name :");
            String name = Console.ReadLine();
            Console.WriteLine("Enter Your Age :");
            String age = Console.ReadLine();
            Console.WriteLine("Your Name Is " + name);
            Console.WriteLine("Your Age Is " + age);
        }
    }
}

