using CSMWebsite2023.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.MySql.Infrastructure
{
    public static class DataRepositoryExtension
    {
        public static void AddDataRepositories(this IServiceCollection services)
            => services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}
