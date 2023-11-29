using bP.Core.Contract.Helpers;
using bP.Core.Models.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core
{
    public static class CoreDependecyInjection
    {
        public static IServiceCollection DependecyInjectionCore(this IServiceCollection services)
        {
            services.AddSingleton<IConfigurationHelpers, ConfigurationHelpers>();
            return services;
        }
    }
}
