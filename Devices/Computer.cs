using System;
using System.Collections.Generic;
using System.Text;

namespace Devices
{
    public class Computer
    {
        public Computer(string name)
        {
            Name = name;
            Time = DateTime.Now;
        }

        public string Name { get; set; }
        public DateTime Time { get; set; }
    }
}
