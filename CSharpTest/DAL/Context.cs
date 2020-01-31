using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.DAL
{
    public class Context : IDisposable
    {
        bool disposed;
        public SqlConnection DB { get; set; }
        public Context()
        {
            string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DB = new SqlConnection(connString);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                DB.Close();
                Console.WriteLine("Connection closed.");
            }

            disposed = true;
        }
    }
}
