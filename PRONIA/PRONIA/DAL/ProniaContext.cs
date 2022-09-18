using System;
using Microsoft.EntityFrameworkCore;
using PRONIA.Models;

namespace pronia.DAL
{
    public class ProniaContext : DbContext
    {
        public ProniaContext(DbContextOptions<ProniaContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}