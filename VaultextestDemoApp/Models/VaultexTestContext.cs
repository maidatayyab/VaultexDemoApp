using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VaultextestDemoApp.Models
{
    public partial class VaultexTestContext : DbContext
    {
        public VaultexTestContext()
        {
        }

        public VaultexTestContext(DbContextOptions<VaultexTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Organisation> Organisations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ARSAMSPC\\SQLEXPRESS;Initial Catalog=VaultexTest; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee$");

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.OrganisationNumber).HasMaxLength(255);
            });

            modelBuilder.Entity<Organisation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Organisation$");

                entity.Property(e => e.AddressLine1).HasMaxLength(255);

                entity.Property(e => e.AddressLine2).HasMaxLength(255);

                entity.Property(e => e.AddressLine3).HasMaxLength(255);

                entity.Property(e => e.AddressLine4).HasMaxLength(255);

                entity.Property(e => e.OrganisationName).HasMaxLength(255);

                entity.Property(e => e.OrganisationNumber).HasMaxLength(255);

                entity.Property(e => e.Postcode).HasMaxLength(255);

                entity.Property(e => e.Town).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
