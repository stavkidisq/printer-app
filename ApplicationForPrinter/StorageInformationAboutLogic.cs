using ApplicationStyles;
using Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationForPrinter
{
    public class StorageInformationAboutLogic // Дописывать сюда всю информацию из бизнесс логики
    {
        public static List<DocumentForPrint> documents = new List<DocumentForPrint>();

        private ComputerWorkWithDocument _informationAboutComputerPrint = new ComputerWorkWithDocument();
        public ComputerWorkWithDocument InformationAboutComputerPrint => _informationAboutComputerPrint;

        private ComputerWorkWithConnection _informationAboutComputerWork = new ComputerWorkWithConnection();
        public ComputerWorkWithConnection InformationAboutComputerWork
        {
            get
            {
                return _informationAboutComputerWork;
            }
        }

        public static async void FillList()
        {
            documents = await ApplicationCache.Cache.UpdateList();
        }
    }
}
