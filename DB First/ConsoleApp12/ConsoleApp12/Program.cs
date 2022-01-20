using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp12
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Data source
            string[] names = { "Thoushif", "Kader",
                "Rifai", "Moha",
                "Saiff", "Mohamed" };

            //UsingLinq(names);

            //UsingLinqExtensions(names);

            //UsingLinqFunctions(names);

            //UsingLinqAnonymousMethods(names);

            //LINQReadXML();

            //LINQtoXmlAddNode();

            LINQtoXmlDeleteNode();

        }
        private static void UsingLinqAnonymousMethods(string[] names)
        {
            Func<string, bool> filter = delegate (string s)
            {
                return s.Length == 5;
            };

            Func<string, string> extract = delegate (string s)
            {
                return s;
            };

            Func<string, string> project = delegate (string s)
            {
                return s.ToUpper();
            };


            IEnumerable<string> query = names.Where(filter)
                                        .OrderBy(extract)
                                        .Select(project);

            // Query execution
            foreach (string item in query)
                Console.Write(item);

            Console.Read();

        }


        private static void UsingLinqFunctions(string[] names)
        {
            Func<string, bool> filter = s => s.Length == 5;
            Func<string, string> extract = s => s;
            Func<string, string> project = s => s.ToUpper();


            IEnumerable<string> query = names.Where(filter)
                                        .OrderBy(extract)
                                        .Select(project);

            // Query execution
            foreach (string item in query)
                Console.Write(item);

            Console.Read();


        }


        private static void UsingLinqExtensions(string[] names)
        {
            IEnumerable<string> query = names
                                        .Where(s => s.Length == 5)
                                        .OrderBy(s => s)
                                        .Select(s => s.ToUpper());

            // Query execution
            foreach (string item in query)
                Console.Write(item);

            Console.Read();


        }

        private static void UsingLinq(string[] names)
        {

            // LINQ Query 
            IEnumerable<string> query = from s in names
                                        where s.Length == 5
                                        orderby s
                                        select s.ToUpper();

            // Query execution
            foreach (string item in query)
                Console.Write(item);

            Console.Read();
        }

        private static void LINQReadXML()
        {
            string myXML = @"<Departments>
                            <Department>Account</Department>
                            <Department>Sales</Department>
                            <Department>Pre-Sales</Department>
                            <Department>Marketing</Department>
                            </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }

            Console.WriteLine("\n Press any key to continue");
            Console.ReadKey();

        }

        private static void LINQtoXmlAddNode()
        {
            string myXML = @"<Departments>
                            <Department>Account</Department>
                            <Department>Sales</Department>
                            <Department>Pre-Sales</Department>
                            <Department>Marketing</Department>
                            </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }

            Console.WriteLine("\n Press any key to continue");
            Console.ReadKey();

        }

        private static void LINQtoXmlDeleteNode()
        {
            string myXML = @"<Departments>
                            <Department>Account</Department>
                            <Department>Sales</Department>
                            <Department>Pre-Sales</Department>
                            <Department>Marketing</Department>
                            </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();
            xdoc.Descendants().Where (s=> s.Value == "Pre-Sales" ).Remove();

            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }

            Console.WriteLine("\n Press any key to continue");
            Console.ReadKey();

        }
    }
}