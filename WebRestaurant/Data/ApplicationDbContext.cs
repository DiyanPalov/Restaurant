using Microsoft.EntityFrameworkCore;
using WebRestaurant.Model;

namespace WebRestaurant.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            :base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
    }
}
