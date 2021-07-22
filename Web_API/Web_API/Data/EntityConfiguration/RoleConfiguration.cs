using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Entities;

namespace Web_API.EntityConfiguration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("User").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("UserId");
            builder.Property(p => p.RoleName).IsRequired().HasColumnName("RoleName").HasMaxLength(50);
        }
    }
}
