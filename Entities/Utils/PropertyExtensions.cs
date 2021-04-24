using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Utils
{
    public static class PropertyExtensions
    {
        public static string toString(this object obj)
        {
            return Convert.ToString(obj);
        }
    }
}
