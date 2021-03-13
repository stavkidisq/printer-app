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
            "Working writh a documents",
            "Quit program"
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
                        WorkingWithDocuments();
                        break;
                    case 2:
                        QuitProgram();
                        break;
                    default:
                        Console.WriteLine("Invalid number!");
                        NavigationAtMainMenu();
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
                        //PrintTheText();
                        break;
                }
            }
        }

        public void WorkingWithDocuments()
        {
            Console.WriteLine("Are you want to see ready document or create a new document?");

            int _num = 0;
            string number = Console.ReadLine();

            if (int.TryParse(number, out _num))
            {
                switch (_num)
                {
                    case 1:
                        InformationAboutDocumentLogic.ShowReadyDocument();
                        MainMenu();
                        break;
                    case 2:
                        InformationAboutDocumentLogic.CreateDocument();
                        MainMenu();
                        break;
                }
            }
        }

        public void QuitProgram()
        {

        }

    }
}
