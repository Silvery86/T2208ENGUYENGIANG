using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace T2208ENGUYENGIANG.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<T2208ENGUYENGIANG.Models.Department>? Department { get; set; }
        public DbSet<T2208ENGUYENGIANG.Models.Employee>? Employee { get; set; }
    }
}
