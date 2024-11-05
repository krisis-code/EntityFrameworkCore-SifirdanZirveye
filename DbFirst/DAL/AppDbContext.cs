using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DbFirst.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext()
        {
            
        }
        public AppDbContext( DbContextOptions<AppDbContext>options) : base(options)
        {

        }
    }
}
