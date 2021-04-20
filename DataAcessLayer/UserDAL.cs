using Common;
using Entities.Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
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

        public Task<QueryResponse<User>> GetAll()
        {
            throw new NotImplementedException();
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
                    await _db.Users.AddAsync(item);
                    //await _db.SaveChangesAsync();
                    return new Response()
                    {
                        Message = "User created.",
                        Success = true
                    };
                }
            }
            catch (Exception ex)
            {

                return new Response()
                {
                    ExceptionMessage = ex.ToString(),
                    Message = "Failed! User not created.",
                    Success = false
                };
            }
        }

        public Task<Response> Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
