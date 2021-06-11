using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace YouTrackSharp
{
   internal static class TypeExtensions
   {
      public static Dictionary<Type, string> _propertyNameCache = new Dictionary<Type, string>();
      
      internal static string JsonFields(this Type type)
      {
         if (_propertyNameCache.ContainsKey(type))
         {
            return _propertyNameCache[type];
         }

         var result = string.Join(",",
            type.GetProperties()
               .Select(p => p.GetCustomAttribute<JsonPropertyAttribute>())
               .Select(jp => jp.PropertyName));

         _propertyNameCache.Add(type, result);

         return result;
      }
   }
}
