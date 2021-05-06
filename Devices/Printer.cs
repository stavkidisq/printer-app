using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationForPrinter
{
    public class Printer
    {
        public IPrint PrintText { get; set; }
        public string Name { get; set; }

        public Printer(string name)
        {

        }

        public void Print(RequestPrintForm request)
        {
            Console.Clear();

            Console.WriteLine("Request recieved succesfully!");


        }

        public void ResponseConnection()
        {

        }
    }
}
