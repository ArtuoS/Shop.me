using Common;
using Common.ResponseModels;
using Entities.Entities;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class UserDAL : IUserService
    {
        private readonly ShopContext _db;

        public UserDAL()
        {
            _db = new ShopContext();
        }

        public Task<Response> Delete(User item)
        {
            throw new NotImplementedException();
        }

        public async Task<QueryResponse<User>> GetAll()
        {
            try
            {
                using (var context = _db)
                {
                    List<User> users = await context
                                       .Users
                                       .ToListAsync();
                    return await QueryResponseModels<User>.SuccessQueryModel(users);
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public Task<SingleResponse<User>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> Insert(User item)
        {
            try
            {
                using (var context = _db)
                {
                    await context.Users.AddAsync(item);
                    await context.SaveChangesAsync();
                    return await ResponseModels.SuccessResponseModel();
                }
            }
            catch (Exception e)
            {
                return await ResponseModels.FailedResponseModel(e.ToString());
            }
        }

        public Task<Response> Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
