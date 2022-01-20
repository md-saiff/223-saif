using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc9.Models;

namespace mvc9.Data
{
    public class mvc9Context : DbContext
    {
        public mvc9Context (DbContextOptions<mvc9Context> options)
            : base(options)
        {
        }

        public DbSet<mvc9.Models.Employee> Employee { get; set; }
    }
}
