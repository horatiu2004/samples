using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using TestWebApplication.Models;

namespace TestWebApplication
{
    public class DataExporter
    {
        public static void ExportToJson(User user)
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(User));
            ser.WriteObject(stream, user);

            stream.Position = 0;
            StreamReader sr = new StreamReader(stream);
            Console.Write("JSON form of Person object: ");
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
