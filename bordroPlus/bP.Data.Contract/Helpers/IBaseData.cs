using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Data.Contract.Helpers
{
    public interface IBaseData<T>
    {
        Task<T> Get(string Key);
        Task<T> Get(T model);
        //Task<T> Get(List<FilterDataModels> Params);
        Task<List<T>> Get();
        Task<T> Add(T model);
        Task Update(Dictionary<string, object> parameters);
        Task Update(T model);
        Task<T> UpdatePut(T model);
        Task Update(string Key, Dictionary<string, string> model);
        Task Delete(string key);
        Task Cancel(string Key);
        Task Close(string key);
    }
}
