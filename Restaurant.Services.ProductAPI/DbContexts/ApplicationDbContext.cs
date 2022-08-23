using Microsoft.EntityFrameworkCore;
using Restaurant.Services.ProductAPI.Models.Dto;
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
    }
}
