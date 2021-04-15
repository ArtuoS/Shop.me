using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Mappings
{
    public class ProductMapConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(u => u.Name).IsRequired().HasMaxLength(60);
            //builder.Property(u => u.Price).IsRequired();
            //builder.Property(u => u.Weight).IsRequired(false);
            //builder.Property(u => u.UnitOfMeasurement).IsRequired(false);
        }
    }
}
