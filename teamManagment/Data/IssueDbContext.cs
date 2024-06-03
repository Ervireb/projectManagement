using Microsoft.EntityFrameworkCore;
using teamManagment.Models;

namespace teamManagment.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            :base(options)
        {
        }
        public DbSet<Issue> Issues { get; set; }
    }
}
