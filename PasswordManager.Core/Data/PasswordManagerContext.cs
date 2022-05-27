using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PasswordManager.Core.Models;

namespace PasswordManager.Core.Data
{
    public partial class PasswordManagerContext : DbContext
    {
        public PasswordManagerContext()
        {
        }

        public PasswordManagerContext(DbContextOptions<PasswordManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<ServicePassword> ServicePasswords { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.33.47\\\\\\\\SQLEXPRESS,1433;Database=PasswordManager;User Id=Administrator;Password=AdminPassword01;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<ServicePassword>(entity =>
            {
                entity.ToTable("ServicePassword");

                entity.Property(e => e.ServicePasswordId)
                    .HasColumnName("service_password_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .HasMaxLength(254)
                    .HasColumnName("user_name");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServicePasswords)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServicePassword_Service");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServicePasswords)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServicePassword_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("birthdate");

                entity.Property(e => e.Email)
                    .HasMaxLength(254)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Login)
                    .HasMaxLength(32)
                    .HasColumnName("login");

                entity.Property(e => e.Salt).HasColumnName("salt");

                entity.Property(e => e.SaltedHash).HasColumnName("salted_hash");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
