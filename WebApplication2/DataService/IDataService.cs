using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.DataService
{
    public interface IDataService<T>
    {        
        Task<List<T>> GetModelsAsync(params object[] keys);        
    }
}