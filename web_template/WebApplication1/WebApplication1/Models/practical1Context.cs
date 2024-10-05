using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class practical1Context : DbContext
    {
        public practical1Context()
        {
        }

        public practical1Context(DbContextOptions<practical1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Std> Stds { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=.;initial catalog=practical1;user id=sa;password=aptech; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Std>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("std");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StdName)
                    .HasMaxLength(225)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StdName)
                    .HasMaxLength(225)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
