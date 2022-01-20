using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp13
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Data source
            string[] names = { "Thoushif","Ahamed", "Kader",
                "Refai", "Moha",
                 "Saifuddeen", "Mohamed", "Yusuf", "Asiff"};
            UsingLinq(names);
        }

            private static void UsingLinq(string[] names)
            {

                // LINQ Query 
                IEnumerable<string> query = from s in names
                                            where s.Length > 5
                                            where s.Contains('a')
                                            orderby s
                                            select s.ToUpper();

                // Query execution
                foreach (string item in query)
                    Console.Write( item +"\n");

                Console.Read();
            }
            
                
        }
    }

