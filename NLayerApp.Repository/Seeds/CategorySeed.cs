using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core.Models;


namespace NLayerApp.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>

    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
            new Category() { Id = 1, Name = "Kalemler" },
            new Category() { Id = 2, Name = "Defterler" },
            new Category() { Id = 3, Name = "Kitaplar" },
            new Category() { Id = 4, Name = "Meyveler" },
            new Category() { Id = 5, Name = "Sebzeler" },
            new Category() { Id = 6, Name = "Et Ürünler" }
            );
        }
    }
}
