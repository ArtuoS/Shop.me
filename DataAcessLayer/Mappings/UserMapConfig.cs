using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Mappings
{
    internal class UserMapConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Name).IsRequired().HasMaxLength(60);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(60);
            builder.Property(u => u.DateOfBirthday).IsRequired();
            builder.Property(u => u.Gender).IsRequired();
            builder.Property(u => u.Email).IsRequired().HasMaxLength(200);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(60);
        }
    }
}
