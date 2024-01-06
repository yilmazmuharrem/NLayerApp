using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Seeds
{
    public class ProductFeatureSeeds : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature() { Id = 1, Height = 100, Width = 50, ProductId = 1, Color = "Red" },
                new ProductFeature() { Id = 2, Height = 230, Width = 30, ProductId = 2, Color = "Blue" }
            );
        }
    }
}
