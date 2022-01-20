using System;

namespace ConsoleApp3
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Product p = new Product();
                string orderName = p.GetOrderName();
                string productName = p.GetProductName();
                Console.WriteLine(orderName + " Belongs too " + productName;
            }
        }
    }
