using BugStore.Core.Models;
using BugStore.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace BugStore.Infra.Extensions
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddContext(services, configuration);
            return services;
        }

        private static void AddContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("Sqlite")));
        }
    }
}