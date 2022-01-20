using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc4.Models;

namespace mvc4.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            IList<Account> Accounts = new List<Account>();
            Accounts.Add(new Account() { Account_ID = 215, AccountHolder_Name = "Kader", AccountHolder_Address = "Thiruvarur" });
            Accounts.Add(new Account() { Account_ID = 222, AccountHolder_Name = "Safi", AccountHolder_Address = "T" });
            Accounts.Add(new Account() { Account_ID = 223, AccountHolder_Name = "Saif", AccountHolder_Address = "PPT" });
            ViewData["Accounts"] = Accounts;
            return View();
        }
    }
}
