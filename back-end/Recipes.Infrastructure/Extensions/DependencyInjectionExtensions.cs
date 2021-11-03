using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Recipes.Infrastructure.Extensions
{
    public static class DependencyInjectionExtensions
    {
        // add by type
        public static void AddLibraryByType<T>(this IServiceCollection services)
		{
            // get the services already configured            
			var alreadyConfigured = services.Select(x => x.ServiceType.Name).ToArray();

			// find all interfaces not already configured
			var interfacesList = typeof(T).GetTypeInfo().Assembly
				.GetTypes()
				.Where(x => x.Name.StartsWith("I") && !alreadyConfigured.Contains(x.Name))
				.ToList();

			// add all classes with matching interfaces
			typeof(T)
				.GetTypeInfo().Assembly
				.GetTypes()
				.Where(x => !x.GetTypeInfo().IsAbstract)
				.ToList()
				.ForEach(thisType =>
				{
					// check if a matching interface
					var thisInterface = interfacesList.FirstOrDefault(i => i.Name == "I" + thisType.Name);
					if (thisInterface != null) 
						services.AddTransient(thisInterface, thisType);
					else if(!alreadyConfigured.Contains(thisType.Name))
						services.AddTransient(thisType);
				});
		}

    }
}