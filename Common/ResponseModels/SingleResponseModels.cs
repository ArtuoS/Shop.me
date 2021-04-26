using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.ResponseModels
{
    public static class SingleResponseModels<T>
    {
        public static async Task<SingleResponse<T>> SuccessSingleModel(T item)
        {
            SingleResponse<T> response = new SingleResponse<T>()
            {
                Data = item,
                Message = "Success!",
                Success = true,
                ExceptionMessage = null
            };
            return response;
        }

        public static async Task<SingleResponse<T>> FailedSingleModel(string exception)
        {
            SingleResponse<T> response = new SingleResponse<T>()
            {
                Message = "Failed!",
                Success = true,
                ExceptionMessage = exception
            };
            return response;
        }
    }
}
