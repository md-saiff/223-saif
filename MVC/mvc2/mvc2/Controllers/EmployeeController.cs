using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc2.Models;
namespace mvc2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {

            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 215, FirstName = "Kader", LastName = "Thoushif" });
            employees.Add(new Employee() { ID = 222, FirstName = "Md", LastName = "Safi" });
            employees.Add(new Employee() { ID = 223, FirstName = "Md", LastName = "Saif" });
            ViewData["employees"] = employees;
            ViewBag.TotalEmployees = employees.Count();
            ViewBag.CompanyName = "Microsoft";
            return View();
        }
    }
}
