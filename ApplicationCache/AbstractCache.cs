using ApplicationForPrinter;
using ApplicationsConfigurations;
using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCache
{
    public abstract class AbstractCache
    {
        public abstract IDictionary<int, IForm> ConnectionCollect { get; set; }

        public void WriteConnection()
        {
        }


    }
}
