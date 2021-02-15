using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationForPrinter
{
    public interface IPrint
    {
        public RequestPrintForm RequestConnection();
    }
}
