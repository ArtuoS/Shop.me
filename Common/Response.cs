using Common.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Response : IResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string ExceptionMessage { get; set; }

        public bool IsSuccess()
        {
            try
            {
                return this.Success;
            }
            catch
            {
                return false;
            }
        }
    }
}
