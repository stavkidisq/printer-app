using ApplicationStyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessInterfaces
{
    public class RequestPrintForm
    {
        public ResponseCode Code { get; set; }
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public TextForm Text { get; set; }
        public Styles TextStyle { get; set; }
        public Policy PrivatePolicy { get; set; }

        public RequestPrintForm(DateTime time, string name, TextForm text, Styles textStyle, Policy policy = Policy.Public)
        {
            time = DateTime.UtcNow;
            name = Name;
            text = Text;
            textStyle = TextStyle;
            policy = PrivatePolicy;
        }
    }
}
