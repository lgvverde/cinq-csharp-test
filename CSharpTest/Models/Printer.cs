using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.Models
{
    public class Printer
    {
        public string PrinterName { get; set; }
        public string SerialKey { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string CustomerName { get; set; }
    }
}
