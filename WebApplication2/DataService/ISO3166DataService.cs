using Microsoft.Data.SqlClient;
using WebApplication2.Models;
using Dapper;
namespace WebApplication2.DataService
{
    public class ISO3166DataServiceDP : IDataService<ISO3166>
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionName = "TP";
        public ISO3166DataServiceDP(IConfiguration configuration) => _configuration = configuration;


        public Task<ISO3166> CreateAsync(ISO3166 model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ISO3166>>  GetListAsync(params object[] keys)
        {
            List<ISO3166> list = new List<ISO3166>();
            string connectionString = string.Empty;
            connectionString = _configuration.GetConnectionString(connectionName);
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = "SELECT top(10) * FROM ISO3166 order by newid()";
                list = (await connection.QueryAsync<ISO3166>(sql)).ToList();
                foreach (ISO3166 iso3166 in list)
                {
                    Console.WriteLine($"{iso3166.Value}");
                }
            }
            return list;
        }

        public Task<ISO3166> GetOneAsync(ISO3166 model)
        {
            throw new NotImplementedException();
        }

        public Task<ISO3166> GetOneAsync(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public Task<List<ISO3166>> GetPageAsync(int pageNumber, int pageSize, params object[] keys)
        {
            throw new NotImplementedException();
        }

        public Task<ISO3166> UpdateAsync(ISO3166 model)
        {
            throw new NotImplementedException();
        }
    }
}
