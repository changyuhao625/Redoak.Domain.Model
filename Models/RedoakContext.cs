using Microsoft.EntityFrameworkCore;

namespace Redoak.Domain.Model.Models
{
    public class RedoakContext : DbContext
    {
        public RedoakContext(DbContextOptions<RedoakContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<GoodsCategory> GoodsCategory { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<GoodsSpec> GoodsSpec { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Identity Spec

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            #endregion

            #region Goods

            modelBuilder.Entity<Goods>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("GoodsId")
                    .IsUnique();

                entity.Property(e => e.CategoryId);
                entity.Property(e => e.Name);
                entity.Property(e => e.DateCreate);
                entity.Property(e => e.DateUpdate);
                entity.Property(e => e.UpdateUser);
            });

            modelBuilder.Entity<GoodsSpec>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("GoodsSpecId")
                    .IsUnique();

                entity.Property(e => e.Name);
                entity.Property(e => e.DateCreate);
                entity.Property(e => e.DateUpdate);
                entity.Property(e => e.UpdateUser);
            });

            modelBuilder.Entity<GoodsCategory>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("GoodsCategoryId")
                    .IsUnique();

                entity.Property(e => e.Name);
                entity.Property(e => e.DateCreate);
                entity.Property(e => e.DateUpdate);
                entity.Property(e => e.UpdateUser);
            });
            #endregion
        }
    }
}