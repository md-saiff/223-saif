using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi1.Models;

namespace WebApi1.Data
{
    public class WebApi1Context : DbContext
    {
        public WebApi1Context (DbContextOptions<WebApi1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApi1.Models.Employee> Employee { get; set; }
    }
}
