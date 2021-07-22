using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Entities;

namespace Web_API.EntityConfiguration
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Message").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("MessageId");
            builder.Property(p => p.DateOfTransmission).IsRequired().HasColumnName("DateOfTransmission").HasColumnType("datetime2");
            builder.HasOne(d => d.User)
                .WithMany(p => p.Messages)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Admin)
                .WithMany(p => p.Messages)
                .HasForeignKey(d => d.AdminId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
