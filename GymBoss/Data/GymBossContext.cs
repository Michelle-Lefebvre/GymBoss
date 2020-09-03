using GymBoss.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GymBoss.Data
{
    public class GymBossContext : IdentityDbContext<IdentityUser>
    {
        public GymBossContext(DbContextOptions<GymBossContext> options)
            : base(options)
        {
        }
        // Alreasy exists in IdentityDbContext public DbSet<User> Users { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Result> Results { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=GymBoss.db");
        }
                protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}