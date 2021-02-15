using ApplicationStyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devices
{
    public class DevicePrint
    {
        public static string Name { get; set; }

        protected Func<string> _createName = delegate ()
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
        };

        protected Func<TextForm> _createText = delegate ()
        {
            string title = null;
            string text = null;

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
        };
    }
}
