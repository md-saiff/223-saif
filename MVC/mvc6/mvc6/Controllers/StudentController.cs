using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace mvc6.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is Index Page..";
        }
        public string StudentDetails()
        {
            return "This is Student Details";
        }
    }
}
