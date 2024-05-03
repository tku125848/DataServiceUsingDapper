using Microsoft.Data.SqlClient;
using WebApplication2.Models;
using Dapper;
using WebApplication2.DbContexts;
using Microsoft.EntityFrameworkCore;
namespace WebApplication2.DataService
{
    public class ISO3166DataServiceEF : IDataService<ISO3166>
    {
        private readonly TpContext _context;
        public ISO3166DataServiceEF(TpContext context) => _context = context;
       

        public Task<List<ISO3166>> GetListAsync(params object[] keys)
        {
            //TpContext context = new TpContext(_configuration);
            List<ISO3166> models = new List<ISO3166>();
            models = _context.ISO3166s
                .FromSqlRaw("SELECT top(10) * FROM ISO3166 order by newid()")
                .AsNoTracking()
                .ToList();
            return Task.FromResult(models);
        }

        public Task<ISO3166> CreateAsync(ISO3166 model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(params object[] keys)
        {
            throw new NotImplementedException();
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
