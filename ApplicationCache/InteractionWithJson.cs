using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ApplicationForPrinter
{
    public class InteractionWithJson : IInteractionWithJson
    {
        public async void SerializeConnectionConfiguration(string name)
        {
            using (FileStream fs = new FileStream("RequestConfig.json", FileMode.OpenOrCreate)) //Создание файла, который будет использоваться для хранения запросов
            {
                await JsonSerializer.SerializeAsync<RequestPrintForm>(fs, new ComputerPrint().RequestConnection()); // Ассинхронная сериализация
            }
        }

        public async void DeserializeConnectionConfiguration(string name) //Чтение файла
        {
            using (FileStream fs = new FileStream("RequestConfig.json", FileMode.OpenOrCreate))
            {
                RequestPrintForm formForRead = await JsonSerializer.DeserializeAsync<RequestPrintForm>(fs);
            }
        }
    }
}
