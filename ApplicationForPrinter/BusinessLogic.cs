using ApplicationsConfigurations;
using BusinessInterfaces;
using Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationForPrinter
{
    public class BusinessLogic
    {
        private string[] _menuList =
        {
            "Create a document",
            "View already created documents",
            "Information about the program",
            "Exit the program"
        };

        private RequestPrintForm _request;

        private RequestPrintForm Request 
        {
            get => _request;
            set => _request = value;
        }

        private ResponsePrintForm Response { get; set; }

        private InteractionWithJson Interaction { get; set; }
        private ComputerPrint InformationAboutComputerPrint { get; set; }

        private Printer InformationAboutPrinter { get; set; }
        private Computer InformationAboutComputer { get; set; }

        public void MainMenu()
        {
            int number = 0;

            Console.WriteLine("Welcome to the Printer2000!");

            for(int i = 0; i < _menuList.Length; i++)
            {
                Console.WriteLine(_menuList[i]);
            }

            Console.WriteLine("Enter the number of the desired function...");

            string numberStr = Console.ReadLine();

            if(int.TryParse(numberStr, out number))
            {
                switch(number)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
        }

        public void SendingInformationAboutRequest()
        {
            string name = InformationAboutComputerPrint.Name; //Вбиваем имя переменной

            InformationAboutComputerPrint.RequestConnection(); //Создаем запрос от компьютера

            InformationAboutComputer = new Computer(name); //Создаем объект компьютера
            Interaction.SerializeInformationAboutDevice(name); //Сериализуем информацию о компьютере
            Interaction.SerializeConnectionConfiguration(Request.Id); //Серриализуем информацию о запросе от компьютера
        }


    }
}
