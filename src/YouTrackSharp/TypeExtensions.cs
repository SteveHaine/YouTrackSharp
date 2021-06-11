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
      
      private static bool IsYouTrack(this Type type)
      {
         return type.Assembly.FullName.StartsWith("YouTrack");
      }

      internal static string JsonFields(this Type type)
      {
         if (_propertyNameCache.ContainsKey(type))
         {
            return _propertyNameCache[type];
         }

         var result = new List<string>();
         var properties = type.GetProperties().Where(p => p.GetCustomAttribute<JsonPropertyAttribute>() != null);

         foreach (var prop in properties)
         {
            var jsonName = prop.GetCustomAttribute<JsonPropertyAttribute>().PropertyName;

            result.Add(prop.PropertyType.IsYouTrack() ?
               $"{jsonName}({prop.PropertyType.JsonFields()})":
               jsonName);
         }

         var fields = string.Join(",", result);

         _propertyNameCache.Add(type, fields);

         return fields;
      }
   }
}
