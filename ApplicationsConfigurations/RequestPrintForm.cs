using ApplicationStyles;
using System;

namespace BusinessInterfaces
{
    public class RequestPrintForm : IRequestForm
    {
        public TextForm Text { get; set; }
        public Styles TextStyle { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public string RecipientName { get; set; }
        public string SenderName { get; set; }
        public Policy PrivatePolicy { get; set; }

        public RequestPrintForm(string recipientName, TextForm text, Styles textStyle, Policy policy = Policy.Public)
        {
            RecipientName = recipientName;
            Text = text;
            TextStyle = textStyle;
            PrivatePolicy = policy;
        }
    }
}
