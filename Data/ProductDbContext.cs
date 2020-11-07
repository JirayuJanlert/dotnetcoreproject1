using authproject.Models;
using Microsoft.EntityFrameworkCore;

namespace authproject.Data
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> ProductsTb { get; set; }
        
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
        : base(options) {



        }



        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Product>().ToTable("ProductsTb");

        // }
    }
}