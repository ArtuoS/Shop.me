using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.ResponseModels
{
    public static class ResponseModels
    {
        public static async Task<Response> SuccessResponseModel()
        {
            Response response = new Response()
            {
                Message = "Success!",
                Success = true,
                ExceptionMessage = null
            };
            return response;
        }

        public static async Task<Response> FailedResponseModel(string ex)
        {
            Response response = new Response()
            {
                Message = "Failed!",
                Success = false,
                ExceptionMessage = ex
            };
            return response;
        }
    }
}
