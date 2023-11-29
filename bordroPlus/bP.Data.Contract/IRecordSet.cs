using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Data.Contract
{
    public interface IRecordSet
    {
        Task<IEnumerable<T>> DoQueryAsync<T>(string Query);
        Task<IEnumerable<T>> DoQueryAsync<T>(string Query, object Params);
        Task<IEnumerable> DoQueryDynamicParameters(string Query, DynamicParameters parameters);
    }
}
