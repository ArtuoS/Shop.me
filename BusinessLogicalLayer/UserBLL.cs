using Common;
using DataAcessLayer;
using Entities.Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class UserBLL : IUserService
    {
        private UserDAL _userDAL = new UserDAL();

        public async Task<Response> Insert(User item)
        {
            if (item != null)
            {
                return await _userDAL.Insert(item);
            }
            return new Response()
            {
                Success = false,
                Message = "Insert failed."
            };
        }

        public Task<Response> Update(User item)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Delete(User item)
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<User>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<QueryResponse<User>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
