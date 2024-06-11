using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Car> cars { get; set; }
        public DbSet<Model> models { get; set; }
        public DbSet<Brand> brands { get; set; }
    }
}
