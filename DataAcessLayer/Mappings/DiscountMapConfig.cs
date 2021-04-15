using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Mappings
{
    public class DiscountMapConfig : IEntityTypeConfiguration<DiscountCoupon>
    {
        public void Configure(EntityTypeBuilder<DiscountCoupon> builder)
        {
            builder.Property(u => u.Coupon).IsRequired().HasMaxLength(20);
            builder.Property(u => u.DiscountPercentage).IsRequired();
            builder.Property(u => u.ExpirationDate).IsRequired();
        }
    }
}
