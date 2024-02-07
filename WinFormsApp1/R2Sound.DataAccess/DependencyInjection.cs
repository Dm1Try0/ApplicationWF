using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using R2Sound.DataAccess.Contracts;
using R2Sound.DataAccess.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2Sound.DataAccess
{
	public static class DependencyInjection 
	{
		public static IServiceCollection AddDataAccessLayer(this IServiceCollection services,IConfiguration configuration)
		{
			var connectionString = configuration.GetConnectionString("User ID=postgres;Password=789789;Host=localhost;Port=5432;Database=test1;");
			return services.AddDbContext<ContextR2Sound>(x => x.UseNpgsql(connectionString), ServiceLifetime.Transient)
				.AddTransient<IUsersDataRepository, UsersDataRepository>();
		}
		public static IServiceProvider InitialDataAccessLayer(this IServiceProvider provider)
		{
			var context = provider.GetService<ContextR2Sound>();
			try
			{
				context?.Database.Migrate();
			}
			catch (Exception e)
			{

			}


			return provider;
		}
	}
}
