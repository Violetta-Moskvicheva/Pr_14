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
            optionsBuilder.UseSqlite("Data Source=pr14.db");
        }
    }
}
