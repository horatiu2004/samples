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
            var js = new DataContractJsonSerializer(typeof(User));
            var stream = File.Create(path: "D:\\Test\\Test.json");          
            js.WriteObject(stream, user);
            
        }
    }
}
