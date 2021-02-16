using ApplicationStyles;
using BusinessInterfaces;
using Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ApplicationForPrinter
{
    public class ComputerPrint : DevicePrint, IPrint
    {
        private static new string Name { get; set; } = "Computer-";

        public RequestPrintForm RequestConnection()
        {
            return new RequestPrintForm
                (_createName(), _createText(), new Styles()); //Создаем информацию о подключении к принтеру
        }
    }
}
