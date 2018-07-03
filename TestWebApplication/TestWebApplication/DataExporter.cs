using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TestWebApplication.Models;


namespace TestWebApplication
{
    public static class DataExporter
    {
        public static void ExportToJson(List<User> users)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(users.GetType());
            Stream stream = File.Create(path: "D:\\Test\\Test.json");
            serializer.WriteObject(stream, users);
            stream.Close();
        }

        public static void ExportToXml(List<User> users)
        {
            XmlSerializer serializer = new XmlSerializer(users.GetType());
            TextWriter writer = new StreamWriter(path: "D:\\Test\\Test.xml");
            serializer.Serialize(writer, users);
            writer.Close();
        }
    }
}
