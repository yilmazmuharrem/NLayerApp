using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Models;
using System.Reflection;

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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // configuratiın yaptığımız classları ıentityconfiguratiın interface sayesinde assemblyleri bulup buraya ekliiyor
            // alternatif olarak              modelBuilder.ApplyConfiguration(new Category());
            base.OnModelCreating(modelBuilder);
        }
    }
}
