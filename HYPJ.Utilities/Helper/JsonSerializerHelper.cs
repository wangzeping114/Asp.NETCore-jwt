using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HYPJ.Utilities.Helper
{
    public class JsonSerializerHelper
    {
        public static string SerializeObject(object obj)
        {
            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            return JsonConvert.SerializeObject(obj, settings);
        }

        public static T DeserializeObject<T>(string json)
        {
            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            return JsonConvert.DeserializeObject<T>(json, settings);
        }
    }
}
