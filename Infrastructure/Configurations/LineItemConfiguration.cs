using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Orders;
using Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class LineItemConfiguration : IEntityTypeConfiguration<LineItem>
    {
        public void Configure(EntityTypeBuilder<LineItem> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne<Product>()
                    .WithMany()
                    .HasForeignKey( li => li.ProductId );

            builder.OwnsOne(p => p.Price, priceBuilder => {
                priceBuilder.Property(m => m.Currency).HasMaxLength(3);
            });
        }
    }
}