using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exercise_3.Model;

namespace Exercise_3.Data
{
    public class Exercise_3Context : DbContext
    {
        public Exercise_3Context (DbContextOptions<Exercise_3Context> options)
            : base(options)
        {
        }

        public DbSet<Exercise_3.Model.Student> Student { get; set; }
    }
}
