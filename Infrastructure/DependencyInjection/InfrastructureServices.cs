using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DependencyInjection
{
    public static class InfrastructureServices
    {
         public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
		{
            string connectionString = configuration.GetConnectionString("DefaultConnection") ??
									  throw new ArgumentNullException(nameof(configuration));

			services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
                
            return services;
        }
    }
}