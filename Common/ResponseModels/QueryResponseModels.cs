using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.ResponseModels
{
    public static class QueryResponseModels<T>
    {
        public static async Task<QueryResponse<T>> SuccessQueryModel(List<T> items)
        {
            QueryResponse<T> response = new QueryResponse<T>()
            {
                Data = items,
                Message = "Success!",
                Success = true,
                ExceptionMessage = null
            };
            return response;
        }

        public static async Task<QueryResponse<T>> FailedQueryModel(string exception)
        {
            QueryResponse<T> response = new QueryResponse<T>()
            {
                Message = "Failed!",
                Success = true,
                ExceptionMessage = exception
            };
            return response;
        }
    }
}
