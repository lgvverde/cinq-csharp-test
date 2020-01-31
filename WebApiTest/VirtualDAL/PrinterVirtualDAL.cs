using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTest.VirtualDAL
{
    public class PrinterVirtualDAL
    {
        public bool SaveCustomers(List<Customer> customerList)
        {
            try
            {
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

                return true;
            }
            catch(Exception er)
            {
                throw er;
            }

        }

        public List<PrinterInfo> SavePrinters(List<PrinterInfo> printerList, List<Customer> customerList)
        {
            try
            {
                //Adding the first Printer into List.
                //Finding the first customer
                Customer customer = customerList.FirstOrDefault(m => m.Id == 1);
                printerList.Add(new PrinterInfo()
                {
                    Name = "Printer 1",
                    SerialKey = "1234",
                    Customer = customer
                });

                //Adding the second Printer into List.
                //Finding the second customer
                customer = customerList.FirstOrDefault(m => m.Id == 2);
                printerList.Add(new PrinterInfo()
                {
                    Name = "Printer 2",
                    SerialKey = "5678",
                    Customer = new Customer()
                    {
                        Id = 2,
                        Name = "Customer 2"
                    }
                });

                return printerList;
            }
            catch (Exception er)
            {
                throw er;
            }

        }
    }
}