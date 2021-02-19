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
            Console.WriteLine("Enter the number of your computer consists of 4 characters...");
            string name = null;

            while (!name.Length.Equals(4))
            {
                Console.WriteLine("The data enterned is incorrect!");
                name = Console.ReadLine();
            }

            Name += name;
            return Name;
        }

        public TextForm CreateTextForPrint()
        {
            string title = null;
            string text;

            Console.WriteLine("Enter the title for the text...");

            while (title.Equals(null))
            {
                Console.WriteLine("The data enterned is incorrect!");
                title = Console.ReadLine();
            }

            text = Console.ReadLine();

            if (text.Equals(null))
            {
                text = "The text is missing!";
            }

            return new TextForm(title, text);
        }

        public void CreateIdForConnection()
        {

        }
    }
}
