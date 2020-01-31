using CSharpTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleTest
{
    [TestClass]
    public class MainTests
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
