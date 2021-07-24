﻿using Entities.Configuration;
using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasIndex(p => new { p.Name, p.Description, p.Cost, p.CategoryId, p.ProviderId }).IsUnique();
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(75);
            modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(300);
            modelBuilder.Entity<Product>().Property(p => p.Cost).IsRequired().HasColumnType("money");
            modelBuilder.Entity<Product>().Property(p => p.CategoryId).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.ProviderId).IsRequired();

            modelBuilder.Entity<Provider>().HasIndex(p => p.Name).IsUnique();
            modelBuilder.Entity<Provider>().Property(p => p.Name).IsRequired().HasMaxLength(75);

            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Provider>().Property(p => p.Name).IsRequired().HasMaxLength(75);

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProviderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Provider> Providers { get; set; }

    }
}
