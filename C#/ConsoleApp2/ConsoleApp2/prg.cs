using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class prg
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            string departmentName = emp.GetDepName();
            string employeeName = emp.GetEmpName();
            Console.WriteLine(employeeName + " Belongs too " + departmentName);
        }
    }
}
