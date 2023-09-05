using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment18.Models;

namespace Assignment18.Data
{
    public class Assignment18DbContext : DbContext
    {
        public Assignment18DbContext (DbContextOptions<Assignment18DbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment18.Models.Movie> Movie { get; set; } = default!;
    }
}
