using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(100);

            builder.Property(x => x.Email).HasMaxLength(255);

            builder.HasIndex(x => x.Email).IsUnique();
        }
    }
}