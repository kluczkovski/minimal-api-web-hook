using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webHookApi.Domain.Entities;
using webHookApi.Domain.Entities.Payload;

namespace webHookApi.Infrastructure.EntityConfigurations
{
    public class PayLoadEntityConfiguration : IEntityTypeConfiguration<PayLoad>
    {
        public void Configure(EntityTypeBuilder<PayLoad> builder)
        {
            builder.ToTable("PayLoad");

            builder.HasKey(p => p.Guid);

            builder.Property(p => p.Action).HasColumnType("varchar(250)");

            builder.HasOne(p => p.Issue)
                .WithOne(i => i.PayLoad)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.RepositoryGit)
                .WithOne(r => r.PayLoad)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Sender)
                .WithOne(s => s.PayLoad)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

