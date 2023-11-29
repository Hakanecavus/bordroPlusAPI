using bP.Core.Contract.Helpers;
using bP.Core.Models.Helpers;
using bP.Data.Contract;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Data
{
    public class RecordSet : IRecordSet
    {
        private IConfigurationHelpers _configuration;
        public RecordSet(IConfigurationHelpers configurationHelpers)
        {
            _configuration = configurationHelpers;
        }

        public async Task<IEnumerable<T>> DoQueryAsync<T>(string Query)
        {
            using (var connection = new SqlConnection(_configuration.DbConnectionString))
            {
                try
                {
                    connection.Open();

                    return await connection.QueryAsync<T>(Query);
                }
                catch (Exception ex)
                {
                    throw new CustomException(500, ex.Message);
                }
            }
        }

        public async Task<IEnumerable<T>> DoQueryAsync<T>(string Query, object Params)
        {
            using (var connection = new SqlConnection(_configuration.DbConnectionString))
            {
                try
                {
                    connection.Open();

                    return await connection.QueryAsync<T>(Query, Params);
                }
                catch (Exception ex)
                {
                    throw new CustomException(500, ex.Message);
                }
            }
        }
        public async Task<IEnumerable> DoQueryDynamicParameters(string Query, DynamicParameters parameters)
        {
            using (var connection = new SqlConnection(_configuration.DbConnectionString))
            {
                try
                {
                    connection.Open();

                    return await connection.QueryAsync(Query, parameters);
                }
                catch (Exception ex)
                {
                    throw new CustomException(500, ex.Message);
                }
            }
        }
    }
}
