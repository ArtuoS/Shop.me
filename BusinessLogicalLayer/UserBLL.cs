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
                return await _userDAL.Insert(item);
            else
                return await ResponseModels.FailedResponseModel(NullPropertyVerifier.NullProperties.NullPropertiesToSting());
        }

        public async Task<Response> Delete(int id)
        {
            if (NullPropertyVerifier.IsIdValid(id))
                return await _userDAL.Delete(id);
            return await ResponseModels.FailedResponseModel($"{id.toString()} is not a valid ID.");
        }

        public async Task<Response> Update(User item)
        {
            if (item != null)
                return await _userDAL.Update(item);
            return await ResponseModels.FailedResponseModel("Object cannot be null.");
        }

        public async Task<SingleResponse<User>> GetById(int id)
        {
            if (NullPropertyVerifier.IsIdValid(id))
                return await _userDAL.GetById(id);
            return await SingleResponseModels<User>.FailedSingleModel($"{id.toString()} is not a valid ID.");
        }

        public async Task<QueryResponse<User>> GetAll()
        {
            return await _userDAL.GetAll();
        }
    }
}
