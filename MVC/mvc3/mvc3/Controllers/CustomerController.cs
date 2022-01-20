using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc3.Models;

namespace mvc3.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            IList<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { CUSTOMER_ID = 215, CUSTOMER_Name = "Kader", CUSTOMER_Address = "Thiruvarur" });
            customers.Add(new Customer() { CUSTOMER_ID = 222, CUSTOMER_Name = "Safi", CUSTOMER_Address = "T" });
            customers.Add(new Customer() { CUSTOMER_ID = 223, CUSTOMER_Name = "Saif", CUSTOMER_Address = "PPT" });
            ViewData["customers"] = customers;
            return View();
        }
    }
}
