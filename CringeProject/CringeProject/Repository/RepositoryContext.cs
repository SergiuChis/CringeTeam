using CringeProject.Entities;
using System.Data.Entity;

namespace CringeProject.Repository {
    public class RepositoryContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Paper> Papers { get; set; }
        public DbSet<Participation> Participations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            /*modelBuilder.Entity<User>()
                .HasOptional(s => s.Paper)
                .WithRequired(p => p.User);*/

            /*modelBuilder.Entity<User>()
                .HasMany<Section>(u => u.Sections)
                .WithMany(s => s.Users)
                .Map(cs => {
                    cs.MapLeftKey("UserRefId");
                    cs.MapRightKey("SectionRefId");
                    cs.ToTable("UserSection");
                });*/
        }
    }
}
