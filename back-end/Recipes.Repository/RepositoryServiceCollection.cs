using System;
using Recipes.Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Recipes.Repository
{
    public static class RepositoryServiceCollection
    {
        // add
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            // add services
            services.AddLibraryByType<Marker>();
            // chain
            return services;
        }
    }

    internal class Marker { }
}
