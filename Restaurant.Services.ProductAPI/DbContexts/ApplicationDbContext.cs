using Microsoft.EntityFrameworkCore;
using Restaurant.Services.ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Test 1",
                Price = 15,
                Description = "Test 1",
                ImageUrl = "https://media.kaufland.com/images/PPIM/AP_Content_1010/std.lang.all/79/68/Asset_817968.jpg",
                CategoryName = "Test 1"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Test 2",
                Price = 13.99,
                Description = "Test 2",
                ImageUrl = "https://media.kaufland.com/images/PPIM/AP_Content_1010/std.lang.all/79/68/Asset_817968.jpg",
                CategoryName = "Test 2"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Test 3",
                Price = 10.99,
                Description = "Test 3",
                ImageUrl = "https://media.kaufland.com/images/PPIM/AP_Content_1010/std.lang.all/79/68/Asset_817968.jpg",
                CategoryName = "Test 3"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Test 4",
                Price = 15,
                Description = "Test 4",
                ImageUrl = "https://media.kaufland.com/images/PPIM/AP_Content_1010/std.lang.all/79/68/Asset_817968.jpg",
                CategoryName = "Test 4 "
            });
        }
    }
}
