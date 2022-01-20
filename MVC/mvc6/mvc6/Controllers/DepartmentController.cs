using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc6.Models;

namespace mvc6.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            IList<Department> Departments = new List<Department>();
            Departments.Add(new Department() { Department_Id = 215, Department_Name = "Kader", Department_Location = "1" });
            Departments.Add(new Department() { Department_Id = 222, Department_Name = "Safi", Department_Location = "2" });
            Departments.Add(new Department() { Department_Id = 223, Department_Name = "Saif", Department_Location = "3" });
            ViewData["Departments"] = Departments;
            return View();
        }
    }
}
