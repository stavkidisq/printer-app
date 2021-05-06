using ApplicationStyles;
using BusinessInterfaces;
using Devices;
using System;

namespace ApplicationForPrinter
{
    public class ComputerWorkWithDocument : ComputerWorkWithText/*, IPrint*/
    {
        //private DocumentForPrint Document { get; set; }

        //public override string Name { get; set; }

        public DocumentForPrint CreateDocumentForPrint(int id)
        {
            return new DocumentForPrint(id, CreateNameTextForPrint(), CreateTextForPrint());
        }
    }
}
