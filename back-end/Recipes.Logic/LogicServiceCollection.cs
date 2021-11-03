using System;
using Recipes.Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Recipes.Logic
{
    public static class LogicServiceCollection
    {
        public static IServiceCollection AddLogic(this IServiceCollection services)
        {
            // add services
            services.AddLibraryByType<Marker>();
            // chain
            return services;
        }
    }

    internal class Marker { }
}
