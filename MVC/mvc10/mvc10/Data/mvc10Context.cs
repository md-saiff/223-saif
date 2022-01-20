using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc10.Models;

namespace mvc10.Data
{
    public class mvc10Context : DbContext
    {
        public mvc10Context (DbContextOptions<mvc10Context> options)
            : base(options)
        {
        }

        public DbSet<mvc10.Models.Department> Department { get; set; }
    }
}
