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

       public DbSet<Category> Categories { get; set; }
       public  DbSet<Product> Products { get; set; } 
       public   DbSet<ProductFeature> ProductFeatures { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
            // configuratiın yaptığımız classları ıentityconfiguratiın interface sayesinde assemblyleri bulup buraya ekliiyor
            // alternatif olarak   modelBuilder.ApplyConfiguration(new Category());



            // BU ŞEKİLDE DE OLDUĞU GİBİ CLEAN CODE YAZMA AÇISINDAN SEEDS ADLI KLASÖRDE YAZMAK DAHA TEMİZ KOD YAZMAMIZI SAĞLAR ! 
            //modelBuilder.Entity<ProductFeature>().HasData(
            //    new ProductFeature() { Id = 1, Height = 100, Width = 50, ProductId = 1, Color = "Red" },
            //    new ProductFeature() { Id = 2, Height = 230, Width = 30, ProductId = 2, Color = "Blue" });




            base.OnModelCreating(modelBuilder);


            
        }
    }
}
