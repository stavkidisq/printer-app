using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationForPrinter
{
    public interface INavigation
    {
        void MainMenu();
        void NavigationAtMainMenu();
        //void NavigationAtTheTextRedactorMenu();
        void WorkingWithDocuments();
        int QuitProgram();
    }
}
