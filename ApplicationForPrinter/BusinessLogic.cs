﻿using ApplicationsConfigurations;
using ApplicationStyles;
using BusinessInterfaces;
using Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationForPrinter
{
    public class BusinessLogic : ILogic
    {
        private RequestPrintForm _request;

        private RequestPrintForm Request 
        {
            get => _request;
            set => _request = value;
        }

        private ResponsePrintForm Response { get; set; }

        private InteractionWithJson Interaction { get; set; }

        private Printer InformationAboutPrinter { get; set; }
        private Computer InformationAboutComputer { get; set; }

        public BusinessLogic()
        {
            StorageInformationAboutLogic.FillList();
            new NavigationBusinessLogic().MainMenu();
        }

        public void SendingInformationAboutRequest()
        {

           //Request = new ComputerWorkWithConnection().RequestConnection()
        }

        public void SendInformation()
        {
            Console.WriteLine("START OF SEND INFORMATION!");
        }
    }
}
