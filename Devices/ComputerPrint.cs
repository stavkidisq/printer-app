﻿using ApplicationStyles;
using BusinessInterfaces;
using Devices;
using System;

namespace ApplicationForPrinter
{
    public class ComputerPrint : DevicePrint, IPrint
    {
        public override string Name { get; set; }

        public RequestPrintForm RequestConnection()
        {
            Name = CreateNameForDevice();

            return new RequestPrintForm
                (Name, CreateTextForPrint()); //Создаем информацию о подключении к принтеру
        }
    }
}
