using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pr_14.Models
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public ApplicationDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=pr14_db;Username=postgres;Password=1111");
        }
    }
}
