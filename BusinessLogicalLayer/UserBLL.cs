using Common;
using Common.ResponseModels;
using DataAcessLayer;
using Entities.Entities;
using Entities.Interfaces;
using Entities.Utils;
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
            NullPropertyVerifier.IsAnyPropertyNull(item);
            if (!NullPropertyVerifier.NullProperties.HasNullProperties())
            {
                return await _userDAL.Insert(item);
            }
            else
            {
                return await ResponseModels.FailedResponseModel(NullPropertyVerifier.NullProperties.NullPropertiesToSting());
            }
        }

        public Task<Response> Update(User item)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> Delete(User item)
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<User>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<QueryResponse<User>> GetAll()
        {
            return await _userDAL.GetAll();
        }
    }
}
