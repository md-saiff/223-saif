using System;
using System.Collections.Generic;
using System.Text;

namespace ex1
{
    
        class Employee : Department
        {
            public void getFirstName()
            {
                Console.WriteLine(" Mohamed ");
            }
            public void getLastName()
            {
                Console.WriteLine(" Saifuddeen ");
            }

            public override void getDepartmentDetail()
            {
                Console.WriteLine(" IT : Developer");
            }
        }
}
