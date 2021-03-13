using ApplicationStyles;
using BusinessInterfaces;
using Devices;
using System;

namespace ApplicationForPrinter
{
    public class ComputerPrint : DevicePrint, IPrint
    {
        private DocumentForPrint Document { get; set; }

        public override string Name { get; set; }

        public RequestPrintForm RequestConnection(int id)
        {
            Name = CreateNameForDevice();

            //return new RequestPrintForm
            //(Name, CreateTextForPrint(id)); //Создаем информацию о подключении к принтеру

            //TODO: Доделать возврат запроса от пользователя к принтеру.
            return null;
        }
    }
}
