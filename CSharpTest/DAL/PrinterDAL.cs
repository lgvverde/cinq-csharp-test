using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.DAL
{
    public class PrinterDAL
    {
        public bool StorePrinter(PrinterInfo printerInfo)
        {
            try
            {
                using (Context ctx = new Context())
                {
                    Console.WriteLine("Connection openned.");
                    ctx.DB.Open();                    

                    string query = "INSERT INTO Printers VALUES(@PrinterName, @SerialKey, @ExpireDate, @CustomerName)";

                    using (SqlCommand cmd = new SqlCommand(query, ctx.DB))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 2500;

                        cmd.Parameters.Add(new SqlParameter("@PrinterName", SqlDbType.VarChar)).Value = printerInfo.Name;
                        cmd.Parameters.Add(new SqlParameter("@SerialKey", SqlDbType.VarChar)).Value = printerInfo.SerialKey;
                        cmd.Parameters.Add(new SqlParameter("@ExpireDate", SqlDbType.DateTime)).Value = DateTime.Now.AddDays(15);
                        cmd.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.VarChar)).Value = printerInfo.Customer.Name;

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        public List<PrinterInfo> GetAllPrinters()
        {
            try
            {
                using (Context ctx = new Context())
                {
                    Console.WriteLine("Connection openned.");
                    ctx.DB.Open();

                    string query = "SELECT * FROM Printers";

                    using (SqlCommand cmd = new SqlCommand(query, ctx.DB))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 2500;

                        SqlDataReader reader = cmd.ExecuteReader();

                        List<PrinterInfo> printerInfoList = new List<PrinterInfo>();
                        while (reader.Read())
                        {
                            PrinterInfo printer = new PrinterInfo();
                            printer.Name = (string)reader["PrinterName"];
                            printer.SerialKey = (string)reader["SerialKey"];
                            printer.ExpireDate = (DateTime?)reader["ExpireDate"];
                            printer.Customer.Name = (string)reader["CustomerName"];
                            printerInfoList.Add(printer);
                        }

                        return printerInfoList;

                    }
                }
            }
            catch (Exception er)
            {
                throw er;
            }
        }
    }
}
