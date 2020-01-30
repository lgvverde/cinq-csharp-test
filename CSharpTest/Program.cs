using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start");
            Console.ReadKey();

            string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("http://localhost:24520/api/printers");
                Console.WriteLine(Environment.NewLine + result);
            }
            
            Console.WriteLine("Done!");
        }
    }
}
