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

        public static async void AddInformationAboutTheFiles(List<DocumentForPrint> documents, FileMode fmode)
        {
            using (FileStream fs = new FileStream("Configurations.json", fmode))
            {
                await JsonSerializer.SerializeAsync<List<DocumentForPrint>>(fs, documents);
            }
        }

        public static async Task<List<DocumentForPrint>> UpdateList() // Проверка эквивалентности имен
        {
            List<DocumentForPrint> documents = new List<DocumentForPrint>();
            using (FileStream fs = new FileStream("Configurations.json", FileMode.Open))
            {
                if(fs.Length != 0) // Сделать проверку того, что нельзя вводить в конфигурационный файл что попало
                    documents = await JsonSerializer.DeserializeAsync<List<DocumentForPrint>>(fs);
            }

            return documents;
        }
    }
}
