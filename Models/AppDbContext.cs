using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebFinal.Models;

namespace WebFinal.Models
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Odev> Odevler { get; set; }

        public DbSet<Students> Students { get; set; }


    }

}
