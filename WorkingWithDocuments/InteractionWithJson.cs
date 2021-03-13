using ApplicationStyles;
using BusinessInterfaces;
using Devices;
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
        private IForm _request;

        public async void SerializeConnectionConfiguration(int id)
        {
            using (FileStream fs = new FileStream($"Connection {id}.json", FileMode.OpenOrCreate)) //Создание файла, который будет использоваться для хранения запросов
            {
                await JsonSerializer.SerializeAsync<IForm>(fs, new ComputerPrint().RequestConnection(id)); // Ассинхронная сериализация
            }
        }

        public async void CreateRegistryOfDocuments(DocumentForPrint doc)
        {
            using(FileStream fs = new FileStream("Registry.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<DocumentForPrint>(fs, doc);
            }
        }

        public async void SerializeInformationAboutDevice(string name)
        {
            using(FileStream fs = new FileStream("config.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Computer>(fs, new Computer(name));
            }
        }

        public async void DeserializeConnectionConfiguration(string name) //Чтение файла
        {
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                Configurations = await JsonSerializer.DeserializeAsync<IForm>(fs);
            }
        }

        //TODO: Не работает текст
        public async void ChangingAnExistingText(string name) // Чтение текста отправленного запроса через файл
        {
            //    using(FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            //    {
            //        RequestPrintForm formForRead = await JsonSerializer.DeserializeAsync<RequestPrintForm>(fs);

            //        formForRead.Text.Text = Console.ReadLine();
            //        fs.Write(Encoding.UTF8.GetBytes(formForRead.Text.Text));

            //        await JsonSerializer.SerializeAsync<RequestPrintForm>(fs, new ComputerPrint().RequestConnection());
            //    }

            //    Console.WriteLine("The text of the file was successfully changed!");
        }

    public async Task<IForm> SearchInformationAboutRequest()
        {
            for(int i = 0; i < IForm.Id; i++)
            {
                using(FileStream fs = new FileStream($"Request {i}.json", FileMode.OpenOrCreate))
                {
                    IForm request = await JsonSerializer.DeserializeAsync<IForm>(fs);
                    _request = request;
                }
            }

            return _request;
        }

        public void Dispose()
        {
            Configurations = null;
        }
    }
}