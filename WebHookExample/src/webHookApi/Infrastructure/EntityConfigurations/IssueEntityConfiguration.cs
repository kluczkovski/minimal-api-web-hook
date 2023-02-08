using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webHookApi.Domain.Entities;
using webHookApi.Domain.Entities.Payload;

namespace webHookApi.Infrastructure.EntityConfigurations
{
    public class IssueEntityConfiguration : IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> builder)
        {
            builder.ToTable("Issue");

            builder.HasKey(i => i.Guid);

            builder.Property(i => i.Url).HasColumnType("varchar(250)");

            builder.Property(i => i.Number).HasColumnType("int");

            builder.Property(p => p.Title).HasColumnType("varchar(100)");
        }
    }
}

