using GymBoss.Models;
using Microsoft.EntityFrameworkCore;
namespace GymBoss.Data
{
    public class GymBossContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Result> Results { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=GymBoss.db");
        }
    }
}