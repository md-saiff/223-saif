using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc7.myLogger
{
    public class MyConsoleLogger: ILog
    {
        public void info(string str)
        {
            Console.WriteLine(str);
        }
    }
}
