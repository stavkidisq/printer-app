using ApplicationStyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessInterfaces
{
    public interface IForm
    {
        public DateTime Time { get; set; }
        public string RecipientName { get; set; }
        public string SenderName { get; set; }
        public Policy PrivatePolicy { get; set; }
    }
}
