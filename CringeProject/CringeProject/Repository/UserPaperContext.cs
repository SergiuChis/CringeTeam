using CringeProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Repository
{
    class UserPaperContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Paper> Papers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOptional(s => s.Paper) // Mark Address property optional in Student entity
                .WithRequired(ad => ad.User); // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student
        }
    }
}
