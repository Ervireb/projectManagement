using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using teamManagment.Models;

namespace teamManagment.Data
{
    public class teamManagmentContext : IdentityDbContext
    {
        public teamManagmentContext (DbContextOptions<teamManagmentContext> options)
            : base(options)
        {
        }
        public DbSet<Project> Project { get; set; } = default!;
    }
}
