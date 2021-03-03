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

        public DocumentForPrint CreateTextForPrint(int id)
        {
            
            string title = null;
            string text;

            Console.WriteLine("Enter the title for the text...");

            while(title.Equals(null) && title.Length < 5)
            {
                Console.WriteLine("The data enterned is incorrect!");
                title = Console.ReadLine();
            }

            Console.WriteLine("Enter the text...");

            text = Console.ReadLine();

            if (text.Equals(null) && text.Length < 10)
            {
                Console.WriteLine("The text is incorrect!");
                text = Console.ReadLine();
            }

            return new DocumentForPrint(id, title, text);
        }
    }
}
