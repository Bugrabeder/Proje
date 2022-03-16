using Microsoft.EntityFrameworkCore;
using Proje1.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Data
{
    class projeDbcontext:DbContext
    {
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Country> Countrys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;user=root;database=proje1;password=159753123147";
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new System.Version(8, 0, 28)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(x => x.name)
                                           .IsRequired()
                                           .HasMaxLength(255);

            modelBuilder.Entity<Order>().HasOne(x => x.customer)
                                        .WithMany(y => y.orders)
                                        .HasForeignKey(z => z.customerId)
                                        .OnDelete(DeleteBehavior.SetNull);


            modelBuilder.Entity<Product>().HasMany(x => x.orders);

            modelBuilder.Entity<Product>().HasData(new Product { id = 1, name = "Lenovo Legion", dateAdded = DateTime.Now, type = "elektronik", numberofStock = 100, price = 12000 });
            modelBuilder.Entity<Product>().HasData(new Product { id = 2, name = "İphone 13 ", dateAdded = DateTime.Now, type = "elektronik", numberofStock = 2200, price = 10000 });
            modelBuilder.Entity<Product>().HasData(new Product { id = 3, name = "Samsung 35x Kamera", dateAdded = DateTime.Now, type = "elektronik", numberofStock = 500, price = 7000 });
            modelBuilder.Entity<Product>().HasData(new Product { id = 4, name = "İphone Şarj aleti", dateAdded = DateTime.Now, type = "elektronik", numberofStock = 1000, price = 120 });
            

        }
    }
}
