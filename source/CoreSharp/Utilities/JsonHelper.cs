using System;
using System.Collections.Generic;
using System.Text;

namespace AndreasReitberger.Core.Utilities
{
    public static class JsonHelper
    {
        /*
        static T TryParse<T>(string jsonData) where T : new()
        {
            JSchemaGenerator generator = new JSchemaGenerator();
            JSchema parsedSchema = generator.Generate(typeof(T));
            JObject jObject = JObject.Parse(jsonData);

            return jObject.IsValid(parsedSchema) ?
                JsonConvert.DeserializeObject<T>(jsonData) : default(T);
        }
        */
        
    }
}
