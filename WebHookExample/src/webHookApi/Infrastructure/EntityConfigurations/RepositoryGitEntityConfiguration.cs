using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webHookApi.Domain.Entities;
using webHookApi.Domain.Entities.Payload;

namespace webHookApi.Infrastructure.EntityConfigurations
{
    public class RepositoryGitEntityConfiguration : IEntityTypeConfiguration<RepositoryGit>
    {
        public void Configure(EntityTypeBuilder<RepositoryGit> builder)
        {
            builder.ToTable("Repository");

            builder.HasKey(r => r.Guid);

            builder.Property(r => r.Id).HasColumnType("int");

            builder.Property(r => r.FullName).HasColumnType("varchar(100)");
        }
    }
}

