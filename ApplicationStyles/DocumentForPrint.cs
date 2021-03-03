using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationStyles
{
    public class DocumentForPrint
    {
        public DocumentForPrint(int id, string name, string text)
        {
            Id = id;
            Name = name;
            Text = text;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }
}
