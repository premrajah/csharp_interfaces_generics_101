using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DotNetInterface101
{
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Doc - DotNetInterface");

            d.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                Console.WriteLine($"Document property changed {e.PropertyName}");
            };
            
            // change properties
            d.DocName = "My Document - Changed";
            d.NeedsSave = true;

            Console.ReadLine();
        }
    }

    class Document : IStorable
    {
        private string name;
        private Boolean mNeedsSave = false;

        // INotifyPropertyChanged requires the implementation of 1 event
        public event PropertyChangedEventHandler PropertyChanged;

        // Utitlity function to call the PropertyChanged Event
        private void NotifyPropChanged(string propName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }


        public Document(string s)
        {
            name = s;
            Console.WriteLine($"Created a document with a name {s}");
        }

        public string DocName
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropChanged("DocName");
            }
        }


        public Boolean NeedsSave
        {
            get { return mNeedsSave; }
            set {
                    mNeedsSave = value;
                    NotifyPropChanged("NeedsSave");
                }
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
