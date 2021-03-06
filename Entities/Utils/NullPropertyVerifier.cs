using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
                // Property is string
                if (property.PropertyType.IsPropertyString())
                    if (string.IsNullOrWhiteSpace(property.GetValue(obj).ToString())) NullProperties.Add(property);

            }
        }

        public static bool IsIdValid(int id)
        {
            if (id > 0)
                return true;
            return false;
        }

        private static bool IsPropertyString(this Type type)
        {
            if (type == typeof(string))
                return true;
            return false;
        }

        public static bool HasNullProperties(this List<PropertyInfo> properties)
        {
            if (properties.Count > 0)
                return true;
            return false;
        }

        public static string NullPropertiesToSting(this List<PropertyInfo> properties)
        {
            var i = 0;
            var propertyNames = string.Empty;
            foreach (PropertyInfo property in properties)
            {
                i++;
                propertyNames += property.Name.toString();
                if (i < properties.Count)
                    propertyNames += ", ";
            }
            propertyNames += " is/are not correct!";
            return propertyNames;
        }
    }
}
