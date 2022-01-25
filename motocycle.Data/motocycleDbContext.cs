using Microsoft.EntityFrameworkCore;
using motocycle.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace motocycle.Data
{
    public class motocycleDbContext : DbContext
    {
        public motocycleDbContext(DbContextOptions<motocycleDbContext> options)
            : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-UHOCSPT;Initial Catalog=librarydb;Persist Security Info=False;User ID=sa;Password=emreD455;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
        //}

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Dimension> Dimension { get; set; }
        public DbSet<Engine> Engine { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Image> Image { get; set; }
    }
}

