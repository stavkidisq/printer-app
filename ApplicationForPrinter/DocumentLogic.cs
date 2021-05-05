using ApplicationStyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationCache;
using System.IO;

namespace ApplicationForPrinter
{
    public class DocumentLogic
    {
        public void CreateDocument() //Создание нового документа
        {
            Console.Clear();
            Console.WriteLine($"Old count List: {StorageInformationAboutLogic.documents.Count}"); //test

            var _document = 
                new StorageInformationAboutLogic().InformationAboutComputerPrint
                .CreateDocumentForPrint(StorageInformationAboutLogic.documents.Count + 1);

            if(CheckingTheFileName(_document))
            {
                StorageInformationAboutLogic.documents.Add(_document); // Запись документа в листинг
                Cache.AddToCache(_document);
                Cache.AddInformationAboutTheFiles
                    (StorageInformationAboutLogic.documents, System.IO.FileMode.OpenOrCreate);
            }
            else
            {
                Console.WriteLine("A document with this name already exists!");
            }

            Console.WriteLine($"New count List: {StorageInformationAboutLogic.documents.Count}"); //test

            //return StorageInformationAboutLogic.documents.FirstOrDefault
            //    (doc => doc.Id == StorageInformationAboutLogic.documents.Count); // Создание документа для печати
        }

        public bool CheckingTheFileName(DocumentForPrint _document)
            => StorageInformationAboutLogic.documents.Find(doc => doc.Name == _document.Name) == null;

        public DocumentForPrint ShowReadyDocument()
        {
            if (StorageInformationAboutLogic.documents.Count >= 1)
            {
                foreach (var _document in StorageInformationAboutLogic.documents.ToArray())
                {
                    Console.WriteLine("Document name: " + _document.Name); // Ввод названия документа для поиска
                }

                Console.WriteLine("Enter the document name...");

                string dName = Console.ReadLine();

                var document =
                    StorageInformationAboutLogic.documents.Find(item => dName == item.Name);

                if (document == null)
                {
                    Console.Clear();
                    Console.WriteLine("There is no document with this name!");
                }
                else
                {
                    return document;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("The list of documents is empty!");
            }

            return null;
        }

        public void DeleteDocument()
        {
            Console.WriteLine("List of documents");
            var documents = StorageInformationAboutLogic.documents;

            foreach (var document in documents)
            {
                Console.WriteLine(document.Name);
            }
            var dName = Console.ReadLine();

            var doc = documents.FirstOrDefault(_doc => dName == _doc.Name);

            if(doc == null)
            {
                Console.WriteLine("This name is invalid!");
            }
            else
            {
                int id = doc.Id;

                documents.Remove(doc);
                UpdateIdForList(documents, id);
                Cache.AddInformationAboutTheFiles(documents, FileMode.Open);
            }
        }

        public void UpdateIdForList(List<DocumentForPrint> documents, int id)
        {
            foreach(var document in documents)
            {
                if(document.Id > id)
                {
                    document.Id -= 1;
                }
            }
        }
    }


}
