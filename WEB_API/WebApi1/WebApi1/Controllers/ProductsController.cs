using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController1>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductController1>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController1>
        [HttpPost]
        public string Post()
        {
            return "You Order Iphone 13 pro";
        }

        // PUT api/<ProductController1>/5
        [HttpPut]
        public string Put()
        {
            return "Your Order Is Placed...";
        }

        // DELETE api/<ProductController1>/5
        [HttpDelete]
        public string Delete()
        {
            return "Your Product Has been cancelled";
        }
    }
}
