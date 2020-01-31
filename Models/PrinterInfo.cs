using System;

namespace Models
{
    public partial class PrinterInfo
    {
        public string Name { get; set; }
        public string SerialKey { get; set; }

        public DateTime? ExpireDate { get; set; }
    }
}