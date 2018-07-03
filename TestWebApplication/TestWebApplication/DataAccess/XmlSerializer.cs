using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestWebApplication.DataAccess
{
    public class MyXmlSerializer : ISerializer
    {
        public TObj Deserialize<TObj>(string aFilePath)
        {
            using (var sr = File.OpenText(aFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TObj));
                return (TObj)serializer.Deserialize(sr.BaseStream);
            }
        }

        public void Serialize(object aObj, string aFilePath)
        {
            using (var sw = File.OpenWrite(aFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(aObj.GetType());
                serializer.Serialize(sw, aObj);
            }
        }
    }
}
