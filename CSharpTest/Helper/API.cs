using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.Helper
{
    public class API
    {
        public static List<PrinterInfo> GetPrintersData()
        {
            using (var client = new WebClient())
            {
                //Adding Headers
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                //Downloading information from WebAPI.
                var result = client.DownloadString("http://localhost:24520/api/printers");

                //Desearializing the Object to Printer Model
                List<PrinterInfo> printerInfoList = JsonConvert.DeserializeObject<List<PrinterInfo>>(result);
                return printerInfoList;
            }
        }
    }
}
