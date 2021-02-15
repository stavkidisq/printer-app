using ApplicationStyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessInterfaces
{
    public interface IRequestForm : IForm
    {
        public TextForm Text { get; set; }
        public Styles TextStyle { get; set; }
    }
}
