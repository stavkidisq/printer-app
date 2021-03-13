using ApplicationForPrinter;
using ApplicationStyles;
using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ApplicationCache
{
    public class Cache : AbstractCache
    {
        public static InteractionWithJson JsonFunctions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static void AddToCache(DocumentForPrint doc)
        {
            string fileName = doc.Name + ".txt";

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                fs.Write(Encoding.UTF8.GetBytes(doc.Text));
            }

            JSonFunctions
        }
    }
}
