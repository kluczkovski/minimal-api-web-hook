using System;
using Microsoft.EntityFrameworkCore;

namespace webHookApi.Infrastructure.InitialiseDataBase
{
	public static class InitialiseDataBase
	{
		public static WebApplication MigrationDataBase(this WebApplication app)
		{
			using var scope = app.Services.CreateScope();

			var context = scope.ServiceProvider.GetService<ApplicationDbContext>();

			context.Database.Migrate();

            return app;
		}
	}
}

