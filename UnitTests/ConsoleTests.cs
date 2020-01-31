using CSharpTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ConsoleTests
    {
        [TestMethod]
        public void ArePrintersNull()
        {
            var printers = Program.GetPrinters();
            Assert.IsNotNull(printers);
        }

        [TestMethod]
        public void DidStore()
        {
            var printers = Program.GetPrinters();
            var success = Program.StorePrinter(printers);
            Assert.IsTrue(success);
        }
    }
}
