using Microsoft.EntityFrameworkCore;

namespace Redoak.Domain.Model.Models
{
    public class RedoakContext : DbContext
    {
        public RedoakContext(DbContextOptions<RedoakContext> options)
            : base(options)
        {
            //Database
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
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<SalesOrder> SalesOrder { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<Quotation> Quotation { get; set; }

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

            // Entity Relations
            modelBuilder.Entity<Goods>()
                .HasOne<GoodsCategory>(g => g.Category)
                .WithMany(c => c.Goods)
                .HasForeignKey(g => g.GoodsCategoryId);

            modelBuilder.Entity<GoodsSpec>()
                .HasOne<Goods>(s => s.Goods)
                .WithMany(g => g.GoodsSpecs)
                .HasForeignKey(s => s.GoodsId);

            modelBuilder.Entity<Customer>()
                .HasOne<Region>(c => c.Region)
                .WithMany(r => r.Customers)
                .HasForeignKey(c => c.RegionId);

            modelBuilder.Entity<Quotation>()
                .HasOne<GoodsSpec>(q => q.GoodsSpec)
                .WithMany()
                .HasForeignKey(q => q.GoodsSpecId);

            modelBuilder.Entity<SalesOrder>()
                .HasOne<Sale>(so => so.Sale)
                .WithMany().
                HasForeignKey(so => so.SaleId);

            modelBuilder.Entity<SalesOrder>()
                .HasOne<Customer>(so => so.Customer)
                .WithMany()
                .HasForeignKey(so => so.CustomerId);

            modelBuilder.Entity<SalesOrder>()
                .HasOne<GoodsSpec>(so => so.GoodsSpec)
                .WithMany()
                .HasForeignKey(so => so.GoodsSpecId);

            modelBuilder.Entity<PurchaseOrder>()
                .HasOne<Purchase>(po => po.Purchase)
                .WithMany()
                .HasForeignKey(po => po.PurchaseId);

            modelBuilder.Entity<PurchaseOrder>()
                .HasOne<Supplier>(po => po.Supplier)
                .WithMany()
                .HasForeignKey(po => po.SupplierId);

            modelBuilder.Entity<PurchaseOrder>()
                .HasOne<GoodsSpec>(po => po.GoodsSpec)
                .WithMany()
                .HasForeignKey(po => po.GoodsSpecId);
            
            // Composite Key
            modelBuilder.Entity<Quotation>()
                .HasKey(p => new { p.GoodsSpecId, p.ProposeDate });
        }
    }
}