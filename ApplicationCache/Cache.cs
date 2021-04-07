using ApplicationForPrinter;
using ApplicationStyles;
using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationCache
{
    public class Cache : AbstractCache
    {
        //public static InteractionWithJson JsonFunctions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public static new InteractionWithJson JsonFunctions 
        { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static void AddToCache(DocumentForPrint doc) // Добавление в кеш
        {
            string fileName = doc.Name + ".txt";

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                fs.Write(Encoding.UTF8.GetBytes(doc.Text));
            }
        }

        public static async void AddInformationAboutTheFiles(List<DocumentForPrint> documents)
        {
            using (FileStream fs = new FileStream("Configurations.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<List<DocumentForPrint>>(fs, documents);
            }
        }

        public static async Task<List<DocumentForPrint>> TryEqualNames() // Проверка эквивалентности имен
        {
            List<DocumentForPrint> documents = new List<DocumentForPrint>();
            using (FileStream fs = new FileStream("Configurations.json", FileMode.Open))
            {
                documents = await JsonSerializer.DeserializeAsync<List<DocumentForPrint>>(fs);
            }

            return documents;
        }
    }
}
