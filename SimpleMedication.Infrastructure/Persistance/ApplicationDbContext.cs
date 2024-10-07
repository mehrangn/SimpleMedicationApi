using Microsoft.EntityFrameworkCore;
using SimpleMedication.Domain.Entities;

namespace SimpleMedication.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Medication> Medications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medication>()
                .HasCheckConstraint("CK_Medication_Quantity", "Quantity > 0");

            modelBuilder.Entity<Medication>()
                .Property(prp => prp.Name)
                .IsRequired();

            modelBuilder.Entity<Medication>()
                .Property(prp => prp.CreationDate)
                .IsRequired();

            modelBuilder.Entity<Medication>()
                .Property(prp => prp.Quantity)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}