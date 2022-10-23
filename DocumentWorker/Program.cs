using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
       public class DocumentWorker
        {
        public string Path;
        
        public DocumentWorker(string path)
        {
            Path = path;
        }
        public virtual void OpenDocument()
            {
                Console.WriteLine("Документ открыт");
            }

            public virtual void EditDocument()
            {
                Console.WriteLine("Редактирование документа доступно в версии про");
            }

            public virtual void SaveDocument()
            {
                Console.WriteLine("Сохранение документа доступно в версии про");
            }
        }

        public class ProDocumentWorker:DocumentWorker
        {
        public ProDocumentWorker(string path) 
            :base(path) { }
        public override void EditDocument()
            {
                Console.WriteLine("Документ отредактирован");
            }

            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии эксп");
            }
        }

        class ExpertDocumentWorker:ProDocumentWorker
         {
        public ExpertDocumentWorker(string path) 
            :base(path) { }
        public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в новом формате");
            }
        }
    class Program
    {
        private const string pro = "111";
        private const string exp = "123";

        static void Main(string[] args)
        {
            Console.WriteLine("Key: ");
            var key = Console.ReadLine();
            var path = @"D:\2 курс\for.txt";
            var documentWorker = new DocumentWorker(path);
            switch (key)
            {
                case pro:
                    documentWorker = new ProDocumentWorker(path);
                    break;
                case exp:
                    documentWorker = new ExpertDocumentWorker(path); break;

            }
            documentWorker.OpenDocument();
            documentWorker.SaveDocument();
            documentWorker.EditDocument();
        }

    }

}
