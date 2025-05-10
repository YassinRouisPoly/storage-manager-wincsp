using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using StorageManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data
{
    public class SMContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductReference> Products { get; set; }
        public DbSet<ProductTransfer> Transfers { get; set; }
        public DbSet<StorageArea> StorageAreas { get; set; }
        public DbSet<StorageBox> StorageBoxes { get; set; }
        public DbSet<StoredProduct> StoredProducts { get; set; }

        public SMContext() { }

        public SMContext(DbContextOptions<SMContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                string uri = "server=localhost;database=storage_manager;user=admin;password=SQL12345";
                options.UseMySql(uri, ServerVersion.AutoDetect(uri));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //UTILISTEURS



            // STOCKAGE
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.Property(c => c.Name)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.HasMany(c => c.Products)
                      .WithOne(p => p.Category)
                      .HasForeignKey(p => p.CategoryId);
            });

            modelBuilder.Entity<ProductReference>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.Property(p => p.Name)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.HasOne(p => p.Category)
                      .WithMany(c => c.Products)
                      .HasForeignKey(p => p.CategoryId);

                entity.HasMany(p => p.StoredProducts)
                      .WithOne(s => s.ProductReference)
                      .HasForeignKey(s => s.ProductReferenceId);
            });

            modelBuilder.Entity<StorageArea>(entity =>
            {
                entity.HasKey(a => a.Id);

                entity.Property(a => a.Name)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.HasMany(a => a.Boxes)
                      .WithOne(b => b.Area)
                      .HasForeignKey(b => b.AreaId);
            });

            modelBuilder.Entity<StorageBox>(entity =>
            {
                entity.HasKey(b => b.Id);

                entity.Property(b => b.Name)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.HasOne(b => b.Area)
                      .WithMany(a => a.Boxes)
                      .HasForeignKey(b => b.AreaId);

                entity.HasMany(b => b.Products)
                      .WithOne(p => p.Box)
                      .HasForeignKey(p => p.BoxId);
            });

            modelBuilder.Entity<StoredProduct>(entity =>
            {
                entity.HasKey(s => s.Id);

                entity.HasOne(s => s.ProductReference)
                      .WithMany(p => p.StoredProducts)
                      .HasForeignKey(s => s.ProductReferenceId);

                entity.HasOne(s => s.Box)
                      .WithMany(b => b.Products)
                      .HasForeignKey(s => s.BoxId);
            });
        }
    }
}
