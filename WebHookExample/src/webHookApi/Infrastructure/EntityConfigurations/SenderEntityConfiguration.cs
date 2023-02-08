using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webHookApi.Domain.Entities;
using webHookApi.Domain.Entities.Payload;

namespace webHookApi.Infrastructure.EntityConfigurations
{
    public class SenderEntityConfiguration : IEntityTypeConfiguration<Sender>
    {
        public void Configure(EntityTypeBuilder<Sender> builder)
        {
            builder.ToTable("Sender");

            builder.HasKey(s => s.Guid);

            builder.Property(s => s.Id).HasColumnType("int");

            builder.Property(s => s.Login).HasColumnType("varchar(100)");
        }
    }
}

