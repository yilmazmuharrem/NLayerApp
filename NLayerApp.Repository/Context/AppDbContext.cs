using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Models;

namespace NLayerApp.Repository.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; } 
        DbSet<ProductFeature> ProductFeatures { get; set; }
    }
}
