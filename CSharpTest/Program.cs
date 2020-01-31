using CSharpTest.DAL;
using CSharpTest.Helper;
using Models;
using System;
using System.Collections.Generic;

namespace CSharpTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start");
            Console.ReadKey();
            Console.WriteLine("Searching for information...");

            try
            {
                var printerList = GetPrinters();

                if (printerList.Count > 0)
                    StorePrinter(printerList);
                else
                    Console.WriteLine("Seems you don't have printers to list!");

                Console.WriteLine("Done!");
                Console.WriteLine("Press any key to exit the application...");
                Console.ReadKey();
            }
            catch (Exception er)
            {
                Console.WriteLine("Error: " + er.Message);
                Console.ReadKey();                
            }

        }

        // GetPrinters
        // Reads the information from an API call, converting the
        // information to a Printer Model.
        public static List<PrinterInfo> GetPrinters()
        {
            try
            {
                List<PrinterInfo> printerInfoList = API.GetPrintersData();
                return printerInfoList;
            }
            catch (Exception er)
            {
                throw er;
            }
        }


        // StorePrinter
        // Stores a printer information in our DB.
        public static bool StorePrinter(List<PrinterInfo> printerInfoList)
        {
            PrinterDAL printerDAL = new PrinterDAL();

            try
            {
                foreach (var printer in printerInfoList)
                {
                    printerDAL.StorePrinter(printer);
                    Console.WriteLine("Printer: " + printer.SerialKey + " - "+ printer.Name + " was stored in our DB.");
                }
                return true;

            }
            catch (Exception er)
            {
                throw er;
            }
        }
    }
}
