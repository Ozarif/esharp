using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Sku).HasConversion(
            sku => sku.Value,
            value => Sku.Create(value)!);

            builder.OwnsOne(p => p.Price, priceBuilder => {
                priceBuilder.Property(m => m.Currency).HasMaxLength(3);
            });
        }
    }
}