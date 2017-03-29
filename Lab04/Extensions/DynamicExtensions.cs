using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.Extensions
{
    public static class DynamicExtensions
    {
        /// <summary>
        /// 加入屬性
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void AddProperty(this ExpandoObject obj, string name, object value)
        {

            var dict = obj as IDictionary<string, object>;
            if (dict.ContainsKey(name))
                dict[name] = value;
            else
                dict.Add(name, value);
        }
    }
}
