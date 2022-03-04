using BezTemp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BezTemp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
            
        }

        // define tables like below
        public DbSet<Sample> Samples { get; set; }
    }
}
