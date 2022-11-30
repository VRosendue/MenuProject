using MenuProject.Models;
using Microsoft.EntityFrameworkCore;

namespace MenuProject.Data
{
    public class AppDbContext : DbContext
    {
      public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        public DbSet<Menu> Menus { get; set; }
    }
}
