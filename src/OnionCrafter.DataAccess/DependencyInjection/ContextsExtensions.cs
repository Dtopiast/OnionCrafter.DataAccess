using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionCrafter.DataAccess.Context;

namespace OnionCrafter.DataAccess.DependencyInjection
{
    /// <summary>
    /// Provides extension methods for registering an EF Data Access Context with the service collection.
    /// </summary>
    public static class ContextsExtensions
    {
        /// <summary>
        /// Adds the specified EF Data Access Context to the service collection.
        /// </summary>
        /// <typeparam name="TDataAccessContext">The type of the EF Data Access Context.</typeparam>
        /// <param name="services">The service collection.</param>
        /// <param name="optionsAction">An optional action to configure the DbContextOptions.</param>
        /// <param name="contextLifetime">The lifetime of the EF Data Access Context.</param>
        /// <param name="optionsLifetime">The lifetime of the DbContextOptions.</param>
        /// <returns>The modified service collection.</returns>
        public static IServiceCollection AddEFDataAccessContext<TDataAccessContext>(
            this IServiceCollection services,
            Action<DbContextOptionsBuilder>? optionsAction = null,
            ServiceLifetime contextLifetime = ServiceLifetime.Scoped,
            ServiceLifetime optionsLifetime = ServiceLifetime.Scoped)
            where TDataAccessContext : DbContext, IBaseDataAccessContext
        {
            services.AddDbContext<TDataAccessContext>(optionsAction, contextLifetime, optionsLifetime);
            return services;
        }
    }
}