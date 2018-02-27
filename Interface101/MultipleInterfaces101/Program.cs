using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces101
{
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("'Test Doc - Multiple'");
            d.Load();
            d.Encrypt();
            d.Save();
            d.Decrypt();
            d.NeedsSave = false;


            Console.ReadLine();
        }
    }

    class Document : IStorable, IEncryptable
    {
        private string name;
        private Boolean mNeedsSave = false;


        public Document(string s)
        {
            name = s;
            Console.WriteLine($"Created a document with a name {s}");
        }


        public Boolean NeedsSave
        {
            get { return mNeedsSave; }
            set { mNeedsSave = value; }
        }

        public void Decrypt()
        {
            Console.WriteLine("Decrypting data...");
        }

        public void Encrypt()
        {
            Console.WriteLine("Encrypting data... ");
        }

        public void Load()
        {
            Console.WriteLine("Loading Document");
        }

        public void Save()
        {
            Console.WriteLine("Saving Document");
        }

    }

    interface IStorable
    {
        void Save();
        void Load();
        Boolean NeedsSave { get; set; }
    }

    interface IEncryptable
    {
        void Encrypt();
        void Decrypt();
    }
}
