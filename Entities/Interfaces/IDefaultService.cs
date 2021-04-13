using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Entities.Interfaces
{
    public interface IDefaultService<T>
    {
        public Response Insert(T item);
        public Response Update(T item);
        public Response Delete(T item);
        public SingleResponse<T> GetById(int id);
        public QueryResponse<T> GetAll();
    }
}
    