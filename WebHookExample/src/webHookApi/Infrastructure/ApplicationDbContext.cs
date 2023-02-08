using System;
using Microsoft.EntityFrameworkCore;

namespace webHookApi.Infrastructure
{
	public sealed class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var assembly = typeof(ApplicationDbContext).Assembly;

			modelBuilder.ApplyConfigurationsFromAssembly(assembly);
		}
	}
}

