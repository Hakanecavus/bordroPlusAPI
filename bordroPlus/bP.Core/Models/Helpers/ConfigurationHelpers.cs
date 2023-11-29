using bP.Core.Contract.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Models.Helpers
{
    public class ConfigurationHelpers : IConfigurationHelpers
    {
        private readonly IConfiguration _configuration;
        public ConfigurationHelpers(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string DbConnectionString => _configuration.GetSection("ConnectionString").Value;
        public string AccessToken => _configuration.GetSection("AppSettings:Token").Value;

    }
}
