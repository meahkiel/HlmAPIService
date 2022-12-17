using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Helper
{
    public static class StringExtension
    {
        public static string WithSingleQuote(this string value, string symbol = "'") {
            
            if(string.IsNullOrEmpty(value)) return value;

            var items = value.Split(",");
            StringBuilder builder = new StringBuilder();
            
            foreach(var item in items) {
               builder.Append("'" + item + "'");
               builder.Append(",");
            }
           
            var returnItem = builder.ToString();

            return returnItem.Substring(0,returnItem.Length - 1);
        }
    }
}