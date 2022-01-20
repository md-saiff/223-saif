using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string DeptName { get; set; }
        public string Course { get; set; }
        public string Location { get; set; }
    }
}
