using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ResponseModels
{
    public static class ResponseModels
    {
        public static Response SuccessResponseModel()
        {
            Response response = new Response()
            {
                Message = "Success!",
                Success = true,
                ExceptionMessage = null
            };
            return response;
        }

        public static Response FailedResponseModel(string ex)
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
