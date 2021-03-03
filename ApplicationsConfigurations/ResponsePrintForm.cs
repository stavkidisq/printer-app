using ApplicationStyles;
using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationsConfigurations
{
    public class ResponsePrintForm : IResponseForm
    {
        public int Id { get; set; }
        public Exception MessageAboutException { get; set; }
        public ResponseCode Code { get; set; }
        public DateTime Time { get; set; }
        public string RecipientName { get; set; }
        public string SenderName { get; set; }
        public Policy PrivatePolicy { get; set; }

        public ResponsePrintForm()
        {
            Id = default;
        }
    }
}
