using Newtonsoft.Json;
//using System.Collections.Generic;

namespace Flysh.Hosp.ProxyApi
{
    public static class GenericExtensions
    {
        public static string ToJson<TObj>(this TObj obj, Formatting format = Formatting.Indented)
        {
            return JsonConvert.SerializeObject(obj, format);
        }

        //public static string ToJson<TObj>(IEnumerable<TObj> obj, Formatting format = Formatting.Indented)
        //{
        //    return JsonConvert.SerializeObject(obj, format);
        //}
    }
}
