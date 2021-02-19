using ApplicationStyles;
using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApplicationForPrinter
{
    public class InteractionWithJson : IInteractionWithJson, IDisposable
    {
        internal IForm Configurations { get; set; }

        public async void SerializeConnectionConfiguration()
        {
            using (FileStream fs = new FileStream("Connection {}", FileMode.OpenOrCreate)) //Создание файла, который будет использоваться для хранения запросов
            {
                await JsonSerializer.SerializeAsync<IForm>(fs, new ComputerPrint().RequestConnection()); // Ассинхронная сериализация
            }
        }

        public async void DeserializeConnectionConfiguration(string name) //Чтение файла
        {
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                Configurations = await JsonSerializer.DeserializeAsync<IForm>(fs);
            }
        }

        public async void ChangingAnExistingText(string name)
        {
            using(FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                RequestPrintForm formForRead = await JsonSerializer.DeserializeAsync<RequestPrintForm>(fs);

                formForRead.Text.Text = Console.ReadLine();
                fs.Write(Encoding.UTF8.GetBytes(formForRead.Text.Text));

                await JsonSerializer.SerializeAsync<RequestPrintForm>(fs, new ComputerPrint().RequestConnection());
            }

            Console.WriteLine("The text of the file was successfully changed!");
        }

        public void Dispose()
        {
            Configurations = null;
        }
    }
}