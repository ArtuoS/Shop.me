using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Entities.Utils
{
    public static class NullPropertyVerifier
    {
        public static List<PropertyInfo> NullProperties { get; set; } = new List<PropertyInfo>();
        public static void IsAnyPropertyNull(object obj)
        {
            foreach (PropertyInfo property in obj.GetType().GetProperties())
            {
                if (property.PropertyType.IsPropertyString())
                {
                    if (string.IsNullOrWhiteSpace(property.GetValue(obj).ToString())) NullProperties.Add(property);
                }
            }
        }

        private static bool IsPropertyString(this Type type)
        {
            if (type == typeof(string))
                return true;
            return false;
        }
    }
}
