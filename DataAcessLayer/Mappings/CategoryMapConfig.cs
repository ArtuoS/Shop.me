using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Mappings
{
    public class CategoryMapConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(u => u.Name).IsRequired().HasMaxLength(20);
            builder.Property(u => u.Description).IsRequired(false).HasMaxLength(60);
        }
    }
}
