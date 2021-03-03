using ApplicationForPrinter;
using ApplicationsConfigurations;
using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCache
{
    public abstract class AbstractCache
    {
        public abstract IDictionary<int, IForm> ConnectionCollect { get; set; }
        public abstract InteractionWithJson JsonFunctions { get; set; }

        public void WriteInformationAboutRequestConnection(int id) // Запись информации о запросе, напрваленном принтеру
        {
            Console.WriteLine("Recording your request...");

            JsonFunctions.SerializeConnectionConfiguration(id); // Серриализация информации

            Console.WriteLine("The information your request was recorded succesfully!");
        }

        public void WriteInformationAboutDevice(string name) // Запись информации о девайсе
        {
            Console.WriteLine("Recording your computer information...");

            JsonFunctions.SerializeInformationAboutDevice(name); // Серриализация информации

            Console.WriteLine("The information was recorded succesfully!");
        }


    }
}
