using ApplicationsConfigurations;
using ApplicationStyles;
using BusinessInterfaces;
using Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationForPrinter
{
    public class BusinessLogic
    {
        private string[] _menuList =
        {
            "Working writh a documents",
            "Quit program"
        };

        private List<DocumentForPrint> documents = new List<DocumentForPrint>();

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

        // Navigation functions
        public void MainMenu()
        {
            int number = 0;

            Console.WriteLine("Welcome to the application is Printer2000!");

            for(int i = 0; i < _menuList.Length; i++)
            {
                Console.WriteLine(_menuList[i]);
            }

            Console.WriteLine("Enter the number of the desired function...");

            string numberStr = Console.ReadLine();

            NavigationAtMainMenu(numberStr, out number);
        }

        public void NavigationAtMainMenu(string numberStr, out int number)
        {
            if (int.TryParse(numberStr, out number))
            {
                switch (number)
                {
                    case 1:
                        WorkingWithDocuments();
                        break;
                    case 2:
                        QuitProgram();
                        break;
                    default:
                        Console.WriteLine("Invalid number!");
                        NavigationAtMainMenu(numberStr, out number);
                        break;
                }
            }
        }

        public void NavigationAtTheTextRedactorMenu()
        {
            int _navigation;

            Console.WriteLine("Save and go back to the main menu or print text (1 - Quit, 2 - Print)?");

            string navigation = Console.ReadLine();

            if (int.TryParse(navigation, out _navigation))
            {
                switch (_navigation)
                {
                    case 1:
                        MainMenu();
                        break;
                    case 2:
                        PrintTheText();
                        break;
                }
            }
        }

        public void WorkingWithDocuments(DocumentForPrint document)
        {
            if (document.Equals(null))
            {

            }
            else
            {

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

        public DocumentForPrint CreateDocument()
        {
            documents.Add(InformationAboutComputerPrint.CreateTextForPrint(documents.Count + 1)); // Запись документа в листинг

            return InformationAboutComputerPrint.CreateTextForPrint(documents.Count + 1); // Создание документа для печати
        }

        public void ShowReadyDocument()
        {
            if(documents.Count >= 1)
            {
                foreach(var _document in documents.ToArray())
                {
                    Console.WriteLine("Document name: " + _document.Name);
                }
            }

            Console.WriteLine("Enter the document name...");

            string dName = Console.ReadLine();

            var document = documents.FirstOrDefault(item => dName == item.Name);

            WorkingWithDocuments(document);
        }

        public void QuitProgram()
        {

        }

        public void PrintTheText()
        {

        }
    }
}
