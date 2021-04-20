using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using Common;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IDefaultService<T>
    {
        public Task<Response> Insert(T item);
        public Task<Response> Update(T item);
        public Task<Response> Delete(T item);
        public Task<SingleResponse<T>> GetById(int id);
        public Task<QueryResponse<T>> GetAll();
    }
}
    