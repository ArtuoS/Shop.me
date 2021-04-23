using Common;
using Entities.Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopMe.Tests.BLL
{
    class FakeUserBLL : IUserService
    {
        public Task<Response> Delete(User item)
        {
            throw new NotImplementedException();
        }

        public Task<QueryResponse<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<User>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Insert(User item)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
