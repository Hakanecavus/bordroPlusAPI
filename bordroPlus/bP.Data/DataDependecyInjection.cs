using bP.Data.Contract;
using bP.Data.DBContext;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bP.Core.Contract.Helpers;

namespace bP.Data
{
    public static class DataDependecyInjection
    {
        private static readonly IConfigurationHelpers _configuration;
        public static IServiceCollection DependencyInjectionData(this IServiceCollection services)
        {
            services.AddSingleton<IRecordSet, RecordSet>();
            //string filePath = @"C:\Users\hakan\source\repos\bordroPlus\bordroPlus\appsettings.json";

            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(Path.GetDirectoryName(filePath))
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //services.AddDbContext<AppDBContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));
            //services.AddDbContext<AppDBContext>(options => options.UseSqlServer(_configuration.DbConnectionString));
            return services;
        }
    }
}
