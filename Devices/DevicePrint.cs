using ApplicationStyles;
using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devices
{
    public abstract class DevicePrint
    {
        public abstract string Name { get; set; }

        public string CreateNameForDevice()
        {
            Console.WriteLine("The computer is given a name...");

            string name = null;

            name += new Random().Next(1000, 9999);

            Name += name;

            Console.WriteLine("The computer has been given a name!");

            return Name;
        }

        private string CreateTextForPrint()
        {
            string text;

            Console.WriteLine("Enter the text...");

            text = Console.ReadLine();

            if (text.Equals(null) && text.Length < 10)
            {
                Console.WriteLine("The text is incorrect!");
                text = Console.ReadLine();
            }

            return text;
        }

        private string CreateNameTextForPrint()
        {
            Console.WriteLine("Enter the title for the text...");

            string name = Console.ReadLine();

            while (name.Equals(null))
            {
                Console.WriteLine("The data enterned is incorrect!");
                name = Console.ReadLine();
            }

            return name;
        }

        public DocumentForPrint CreateDocumentForPrint(int id)
        {
            return new DocumentForPrint(id, CreateNameTextForPrint(), CreateTextForPrint());
        }
    }
}
