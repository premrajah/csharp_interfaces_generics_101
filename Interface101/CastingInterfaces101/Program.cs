using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingInterfaces101
{
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("'Test Doc - Casting");

            // is operator
            if (d is IStorable)
                d.Save();

            // use the as operator
            IStorable intStor = d as IStorable;
            if (intStor != null)
                d.Load();

            d.NeedsSave = false;
            

            Console.ReadLine();
        }
    }

    class Document : IStorable
    {
        private string name;
        private Boolean mNeedsSave = false;

        public Document(string s)
        {
            name = s;
            Console.WriteLine($"Created a document with name {s}");
        }

        public bool NeedsSave
        {
            get { return mNeedsSave; }
            set { mNeedsSave = value; }
        }

        public void Load()
        {
            Console.WriteLine("Loading..");
        }

        public void Save()
        {
            Console.WriteLine("Saving...");
        }
    }

    interface IStorable
    {
        void Load();
        void Save();
        Boolean NeedsSave { get; set; }
    }
}
