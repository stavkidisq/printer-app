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
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RequestPrintForm RequestConnection()
        {
            return new RequestPrintForm
                (CreateNameForDevice(), CreateTextForPrint()); //Создаем информацию о подключении к принтеру
        }

        public void SendingToTheCache()
        {
            Console.WriteLine("The data is serialized...");

            
        }
    }
}
