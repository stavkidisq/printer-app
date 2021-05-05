using ApplicationForPrinter;
using ApplicationStyles;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests
{
    public class DocumentLogicTests
    {
        [Fact]
        public void TryCreateDocuments()
        {
            DocumentLogic document = new DocumentLogic();
            var bval = document.CheckingTheFileName(new DocumentForPrint { Name = "Document1" });
            Assert.True(bval);


        }
    }
}
