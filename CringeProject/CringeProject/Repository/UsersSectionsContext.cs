using CringeProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Repository
{
    class UsersSectionsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Section> Sections { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany<Section>(s => s.Sections)
                .WithMany(c => c.Users)
                .Map(cs =>
                {
                    cs.MapLeftKey("UserRefId");
                    cs.MapRightKey("SectionRefId");
                    cs.ToTable("UserSection");
                });
        }
    }
}
