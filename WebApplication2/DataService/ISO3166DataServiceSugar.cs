using Microsoft.Data.SqlClient;
using SqlSugar;
using WebApplication2.Models;

namespace WebApplication2.DataService
{
    public class ISO3166DataServiceSugar : IDataService<ISO3166>
    {
        private SqlSugarClient _client;
        public ISO3166DataServiceSugar(SqlSugarClient client)
        {
            _client = client;
        }
        public Task<ISO3166> CreateAsync(ISO3166 model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ISO3166>> GetListAsync(params object[] keys)
        {
            //throw new NotImplementedException();
            List<ISO3166> list = _client.Queryable<ISO3166>()
                .Take(100).ToList();

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
