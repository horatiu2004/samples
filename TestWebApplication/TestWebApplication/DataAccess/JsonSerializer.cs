using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace TestWebApplication.DataAccess
{
    public class JsonSerializer : ISerializer
    {
        public TObj Deserialize<TObj>(string aFilePath)
        {
            using (var sr = File.OpenText(aFilePath))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TObj));
                return (TObj)serializer.ReadObject(sr.BaseStream);
            }
        }

        public void Serialize(object aObj, string aFilePath)
        {
            using (var sw = File.OpenWrite(aFilePath))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(aObj.GetType());
                serializer.WriteObject(sw, aObj);
            }
        }
    }
}
