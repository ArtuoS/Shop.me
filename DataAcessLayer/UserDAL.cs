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

        public async Task<Response> Delete(int id)
        {
            try
            {
                using var context = _db;
                context
                    .Users
                    .Remove(new User()
                    {
                        Id = id
                    });
                await context.SaveChangesAsync();
                return await ResponseModels.SuccessResponseModel();
            }
            catch (Exception e)
            {
                return await ResponseModels.FailedResponseModel(e.ToString());
            }
        }

        public async Task<QueryResponse<User>> GetAll()
        {
            try
            {
                using var context = _db;
                List<User> users = await context
                                   .Users
                                   .Include(s => s.Stores)
                                   .ToListAsync();
                return await QueryResponseModels<User>.SuccessQueryModel(users);
            }
            catch (Exception e)
            {

                return await QueryResponseModels<User>.FailedQueryModel(e.ToString());
            }
        }

        public async Task<SingleResponse<User>> GetById(int id)
        {
            try
            {
                using var context = _db;
                var user = await context
                           .Users
                           .FirstOrDefaultAsync(u => u.Id == id);
                return await SingleResponseModels<User>.SuccessSingleModel(user);
            }
            catch (Exception e)
            {
                return await SingleResponseModels<User>.FailedSingleModel(e.ToString());
            }
        }

        public async Task<Response> Insert(User item)
        {
            try
            {
                using var context = _db;
                await context.Users.AddAsync(item);
                await context.SaveChangesAsync();
                return await ResponseModels.SuccessResponseModel();
            }
            catch (Exception e)
            {
                return await ResponseModels.FailedResponseModel(e.ToString());
            }
        }

        public async Task<Response> Update(User item)
        {
            try
            {
                using var context = _db;
                context
                    .Users
                    .Update(item);
                await context.SaveChangesAsync();
                return await ResponseModels.SuccessResponseModel();
            }
            catch (Exception e)
            {
                return await ResponseModels.FailedResponseModel(e.ToString());
            }
        }
    }
}
