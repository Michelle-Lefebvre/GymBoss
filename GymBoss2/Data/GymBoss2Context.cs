using GymBoss2.Models;
using Microsoft.EntityFrameworkCore;
namespace GymBoss2.Data
{
    public class GymBoss2Context : DbContext
    {
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Client> Clients { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=GymBoss2.db");
        }
    }
}