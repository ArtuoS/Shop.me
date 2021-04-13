using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
