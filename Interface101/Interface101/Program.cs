using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface101
{
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("'Test Document' - 101.");
            d.Load();
            d.Save();
            d.NeedsSave = false;

            Console.ReadLine();
        }
    }

    class Document :IStorable
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
            get { return mNeedsSave;  }
            set { mNeedsSave = value; }
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
}
