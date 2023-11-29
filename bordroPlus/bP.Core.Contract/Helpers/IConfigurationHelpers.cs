using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Contract.Helpers
{
    public interface IConfigurationHelpers
    {
        string DbConnectionString { get; }
        string AccessToken { get; }
    }
}
