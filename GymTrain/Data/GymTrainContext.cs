using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GymTrain.Models;

namespace GymTrain.Data
{
    public class GymTrainContext : DbContext
    {
        public GymTrainContext (DbContextOptions<GymTrainContext> options)
            : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Result>().ToTable("Result");
            modelBuilder.Entity<Session>().ToTable("Session");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Trainer>().ToTable("Trainer");
        }
        public DbSet<GymTrain.Models.Client> Client { get; set; }
    }
}
