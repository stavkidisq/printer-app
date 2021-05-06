using ApplicationStyles;
using BusinessInterfaces;
using Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationForPrinter
{
    public class NavigationBusinessLogic : INavigation
    {
        private DocumentLogic informationAboutDocumentLogic 
            = new DocumentLogic();

        private DocumentLogic InformationAboutDocumentLogic => informationAboutDocumentLogic;

        private IEnumerable<string> _menuList = new List<string>()
        {
            "1 - [Working with a documents]",
            "2 - [Quit program]"
        };

        public void MainMenu()
        {
            Console.WriteLine("Welcome to the application is Printer2000!");

            foreach (var _menuItem in _menuList)
            {
                Console.WriteLine(_menuItem);
            }

            NavigationAtMainMenu();
        }

        public void NavigationAtMainMenu()
        {
            Console.WriteLine("Enter the number of the desired function...");

            int number = 0;
            string numberStr = Console.ReadLine();

            if (int.TryParse(numberStr, out number))
            {
                switch (number)
                {
                    case 1:
                        WorkingWithDocuments(); // Работа с документами
                        break;
                    case 2:
                        SendInformationAboutDocumentToPrinter(); // Распечатка файла
                        break;
                    case 3:
                        QuitProgram(); // Выход из программы
                        break;
                    default:
                        Console.WriteLine("Invalid number!");
                        NavigationAtMainMenu();
                        break;
                }
            }
        }

        //public void NavigationAtTheTextRedactorMenu()
        //{
        //    int _navigation;

        //    Console.WriteLine("Save and go back to the main menu or print text (1 - Quit, 2 - Print)?");

        //    string navigation = Console.ReadLine();

        //    if (int.TryParse(navigation, out _navigation))
        //    {
        //        switch (_navigation)
        //        {
        //            case 1:
        //                MainMenu();
        //                break;
        //            case 2:
        //                SendInformationAboutDocumentToPrinter();
        //                break;
        //            default:
        //                //PrintTheText();
        //                break;
        //        }
        //    }
        //}

        public void WorkingWithDocuments()
        {
            Console.WriteLine("Are you want to see ready document or create a new document?");
            Console.WriteLine("1 - [Show a ready document]");
            Console.WriteLine("2 - [Create a new document]");
            Console.WriteLine("3 - [Delete a document]");

            int _num = 0;
            string number = Console.ReadLine();

            if (int.TryParse(number, out _num))
            {
                switch (_num)
                {
                    case 1:
                        Console.Clear();
                        var readyDocument = InformationAboutDocumentLogic.ShowReadyDocument(); // Просмотреть готовые документы
                        if(readyDocument != null)
                            Console.WriteLine($"Name:  \n {readyDocument.Name} \nText:  \n {readyDocument.Text}");
                        MainMenu();
                        break;
                    case 2:
                        Console.Clear();
                        InformationAboutDocumentLogic.CreateDocument(); //Создать новый документ
                        MainMenu();
                        break;
                    case 3:
                        Console.Clear();
                        InformationAboutDocumentLogic.DeleteDocument();
                        MainMenu();
                        break;
                }
            }
        }

        public void SendInformationAboutDocumentToPrinter()
        {
            var document = InformationAboutDocumentLogic.ShowReadyDocument();

            int number = new Random().Next(0, 1000);

            var computer = new Computer("Computer-" + number);
            var printer = new Printer("Printer-" + number + 1);

            var request = new RequestPrintForm(printer.Name, document, Policy.Public);


        }



        public int QuitProgram()
        {
            return 0;
        }

    }
}
