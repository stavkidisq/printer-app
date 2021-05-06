using ApplicationStyles;
using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devices
{
    public class ComputerWorkWithConnection
    {
        public RequestPrintForm RequestConnection(int id, DocumentForPrint document)
        {
            string printerName = "Printer-" + new Random().Next(2000, 3000);
            //string computerName = "Computer-" + new Random().Next(1000, 2000);

            var request = new RequestPrintForm(printerName, document, Policy.Private);

            return request;
        }
    }
}
