using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces101
{
    class Program
    {
        static void Main(string[] args)
        {
            FooBar fb = new FooBar();
            fb.SomeMethod();

            IFoo ifoo = fb as IFoo;
            ifoo.SomeMethod();

            IBar ibar = fb as IBar;
            ibar.SomeMethod();


            Console.ReadLine();
        }
    }


    class FooBar : IFoo, IBar
    {
        void IFoo.SomeMethod()
        {
            Console.WriteLine("IFoo's Method");
        }

        void IBar.SomeMethod()
        {
            Console.WriteLine("IBar's Method");
        }

        public void SomeMethod()
        {
            Console.WriteLine($"This is SomeMethod");
        }
    }

    interface IFoo
    {
        void SomeMethod();
    }

    interface IBar
    {
        void SomeMethod();
    }


    
}
