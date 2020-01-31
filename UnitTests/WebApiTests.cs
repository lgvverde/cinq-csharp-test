using WebApiTest.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Models;

namespace UnitTests
{
    [TestClass]
    public class WebApiTests
    {
        [TestMethod]
        public void DidSaveCustomers()
        {
            List<Customer> customerList = new List<Customer>();

            //Adding the first Customer into List.
            customerList.Add(new Customer()
            {
                Id = 1,
                Name = "Customer 1"
            });

            //Adding the second Customer into List.
            customerList.Add(new Customer()
            {
                Id = 2,
                Name = "Customer 2"
            });

            var success = PrintersController.virtualDAL.SaveCustomers(customerList);
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void DidSavePrinters()
        {
            List<PrinterInfo> printerInfoList = new List<PrinterInfo>();
            List<Customer> customerList = new List<Customer>();

            //Adding the first Customer into List.
            customerList.Add(new Customer()
            {
                Id = 1,
                Name = "Customer 1"
            });

            //Adding the second Customer into List.
            customerList.Add(new Customer()
            {
                Id = 2,
                Name = "Customer 2"
            });

            var printers = PrintersController.virtualDAL.SavePrinters(printerInfoList, customerList);
            Assert.IsNotNull(printers);
        }
    }
}
