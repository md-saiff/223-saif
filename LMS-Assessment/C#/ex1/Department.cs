using System;
using System.Collections.Generic;
using System.Text;
namespace ex1
{    abstract class Department
    {

        public void getDepartmentName()
        {
            Console.WriteLine("IT Department");
            Console.WriteLine("Accounts Department");
        }

        public void getNumberOfDepartment()
        {
            Console.WriteLine(" 2 ");
        }

        public virtual void getDepartmentDetail()
        {
            Console.WriteLine(" IT : Developer, Accounts : Admin ");
        }
    }
}

    


