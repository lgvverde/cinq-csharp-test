using Models;
using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApiTest.VirtualDAL;

namespace WebApiTest.Controllers
{
    public class PrintersController : ApiController
    {
        // GET api/printers
        public static List<PrinterInfo> printerList = new List<PrinterInfo>();
        public static List<Customer> customerList = new List<Customer>();
        public static PrinterVirtualDAL virtualDAL = new PrinterVirtualDAL();

        //Standard route (index) for this Controller.
        public List<PrinterInfo> Get()
        {
            try
            {
                virtualDAL.SaveCustomers(customerList);

                if(customerList != null && customerList.Count > 0)
                    virtualDAL.SavePrinters(printerList, customerList);

                if (printerList != null && printerList.Count > 0)
                    return printerList;

                else return new List<PrinterInfo>();
            }
            catch (Exception er)
            {
                throw er;
            }

        }
    }
}
