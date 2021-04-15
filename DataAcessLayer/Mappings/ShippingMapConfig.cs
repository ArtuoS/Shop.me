using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Mappings
{
    public class ShippingMapConfig : IEntityTypeConfiguration<Shipping>
    {
        public void Configure(EntityTypeBuilder<Shipping> builder)
        {
            builder.Property(u => u.ExpectedArriveDate).IsRequired();
            builder.Property(u => u.DepartureDate).IsRequired();
            builder.Property(u => u.ArriveDate).IsRequired(false);
        }
    }
}
