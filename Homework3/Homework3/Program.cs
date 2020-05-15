using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Achar sozu daxil edin: ");
            string key = Console.ReadLine();

            DocumentProgram docProgram;

            switch(key)
            {
                case "basic":
                    docProgram = new DocumentProgram();
                    break;
                case "pro":
                    docProgram = new ProDocumentProgram();
                    break;
                case "expert ":
                    docProgram = new ExpertDocument();
                    break;

                default:
                    return;
            }

            ShowMethods(docProgram);
        }

        static void ShowMethods(DocumentProgram docProgram)
        {
            docProgram.OpenDocument();
            docProgram.EditDocument();
            docProgram.SaveDocument();
        }
    }


    class DocumentProgram
    {

        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");

        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");

        }
    }


    class ProDocumentProgram : DocumentProgram
    {
        public sealed override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");

        }


    }

    class ExpertDocument : ProDocumentProgram
    {

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");

        }

    }
}
