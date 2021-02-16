using ApplicationStyles;
using System;

namespace BusinessInterfaces
{
    public interface IResponseForm : IForm
    {
        public Exception MessageAboutException { get; set; }
        public ResponseCode Code { get; set; }
    }
}
