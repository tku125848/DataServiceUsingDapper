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
       

        public async Task<List<ISO3166>> GetModelsAsync(params object[] keys)
        {
            //TpContext context = new TpContext(_configuration);
            List<ISO3166> models = new List<ISO3166>();
            models = _context.ISO3166s
                .FromSqlRaw("SELECT top(10) * FROM ISO3166 order by newid()")
                .AsNoTracking()
                .ToList();
            return models;
        }


    }
}
