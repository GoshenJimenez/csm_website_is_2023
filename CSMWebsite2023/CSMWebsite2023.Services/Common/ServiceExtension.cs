using CSMWebsite2023.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.Services.Common
{
    public static class ServiceExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddMemoryCache();
            //services.AddHttpContextAccessor();

            var types = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(p => typeof(IService).IsAssignableFrom(p) && p.IsClass && !p.IsAbstract);

            foreach (var type in types)
            {
                var typeInterface = type.GetInterface($"I{type.Name}");

                if (typeInterface == null)
                    continue;

                services.AddScoped(typeInterface, type);
            }
        }
    }
}
