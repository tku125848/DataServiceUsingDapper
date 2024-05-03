using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.DataService
{
    public interface IDataService<T>
    {
        public Task<T> GetOneAsync(T model);
        public Task<T> GetOneAsync(params object[] keys);
        public Task<List<T>> GetListAsync(params object[] keys);
        public Task<List<T>> GetPageAsync(int pageNumber, int pageSize, params object[] keys);
        public Task<T> CreateAsync(T model);
        public Task<T> UpdateAsync(T model);
        public Task<bool> DeleteAsync(params object[] keys);
        
    }
}