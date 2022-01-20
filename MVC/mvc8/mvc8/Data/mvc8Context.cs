using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc8.Models;

namespace mvc8.Data
{
    public class mvc8Context : DbContext
    {
        public mvc8Context (DbContextOptions<mvc8Context> options)
            : base(options)
        {
        }

        public DbSet<mvc8.Models.Student> Student { get; set; }
    }
}
