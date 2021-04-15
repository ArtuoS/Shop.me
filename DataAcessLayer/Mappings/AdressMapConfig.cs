using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Mappings
{
    public class AdressMapConfig : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.Property(u => u.Country).IsRequired();
            builder.Property(u => u.State).IsRequired();
            builder.Property(u => u.City).IsRequired();
        }
    }
}
