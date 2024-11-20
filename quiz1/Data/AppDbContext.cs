using Microsoft.EntityFrameworkCore;
using WebApi_Abdelrhman_khaled_0522015_S4.Models;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Movie> ?Movies { get; set; }
        public DbSet<Director> ?Directors { get; set; }
        public DbSet<Nationality> ?nationalities { get; set; }
        public DbSet<Category> ?categories { get; set; }

    }
}
