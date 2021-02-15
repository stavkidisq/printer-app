using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationStyles
{
    public class TextForm
    {
        public TextForm(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public string Title { get; set; }
        public string Text { get; set; }
    }
}
