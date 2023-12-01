using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using teamManagment.Models;

namespace teamManagment.Data
{
    public class teamManagmentContext : DbContext
    {
        public teamManagmentContext (DbContextOptions<teamManagmentContext> options)
            : base(options)
        {
        }
        public DbSet<teamManagment.Models.Project> Project { get; set; } = default!;
    }
}
