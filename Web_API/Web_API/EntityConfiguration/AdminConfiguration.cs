using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Entities;

namespace Web_API.EntityConfiguration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admin").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("AdminId");
            builder.Property(p => p.Nickname).IsRequired().HasColumnName("Nickname").HasMaxLength(50);
            builder.Property(p => p.RegestrationDate).IsRequired().HasColumnName("RegestrationDate").HasColumnType("datetime2");
        }
    }
}
