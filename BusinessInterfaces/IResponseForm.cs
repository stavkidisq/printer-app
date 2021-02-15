using ApplicationStyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessInterfaces
{
    public interface IResponseForm : IForm
    {
        public Exception MessageAboutException { get; set; }
        public ResponseCode Code { get; set; }
    }
}
