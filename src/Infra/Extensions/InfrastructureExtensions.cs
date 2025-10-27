using BugStore.Core.Interfaces;
using BugStore.Infra.Data;
using BugStore.Infra.Repositories;
using BugStore.Application.Handlers.Customers;
using BugStore.Application.Handlers.Products;
using Microsoft.EntityFrameworkCore;

namespace BugStore.Infra.Extensions
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddContext(services, configuration);
            AddRepositories(services);
            AddHandlers(services);
            return services;
        }

        private static void AddContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("Sqlite")));
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        private static void AddHandlers(IServiceCollection services)
        {
            services.AddScoped<BugStore.Application.Handlers.Customers.Handler>();
            services.AddScoped<BugStore.Application.Handlers.Products.Handler>();
        }
    }
}