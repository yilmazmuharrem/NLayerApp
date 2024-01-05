using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core.Models;

namespace NLayerApp.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product() { Id = 1, CategoryId = 1, Name = "Faber Castell", Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                new Product() { Id = 2, CategoryId = 1, Name = "Mikro", Price = 85, Stock = 250, CreatedDate = DateTime.Now },
                new Product() { Id = 3, CategoryId = 1, Name = "Pencil", Price = 1200, Stock = 201, CreatedDate = DateTime.Now },
                new Product() { Id = 4, CategoryId = 4, Name = "Elma", Price = 12, Stock = 96, CreatedDate = DateTime.Now },
                new Product() { Id = 5, CategoryId = 4, Name = "Kiraz", Price = 17, Stock = 87, CreatedDate = DateTime.Now },
                new Product() { Id = 6, CategoryId = 3, Name = "Dünyanin Merkezine Yolculuk", Price = 17, Stock = 87, CreatedDate = DateTime.Now },
                new Product() { Id = 7, CategoryId = 3, Name = "Mesnevi", Price = 170, Stock = 1000, CreatedDate = DateTime.Now },
                new Product() { Id = 8, CategoryId = 3, Name = "Mutluluk", Price = 102, Stock = 875, CreatedDate = DateTime.Now }
                );
        }
    }
}
