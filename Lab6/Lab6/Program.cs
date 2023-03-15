using System;
//1:1
namespace Lab6
{
    class E
    {
        public E () { Console.WriteLine("Constructor E"); }
        public E ( F f)
        { 
            Console.WriteLine("Constructor E(F f)");
            this.f = f;
        }
        ~E() { Console.WriteLine("destructor E"); }

        public void opE() { Console.WriteLine(" op class E "); }

        public F f { set; get; } = null;
    }

    class F
    {
        public F() { Console.WriteLine("Constructor F"); }
        public F(E e) 
        { 
            Console.WriteLine("Constructor F(E e)");
            this.e = e;
            this.e.f = this; //!
        }
        ~F() { Console.WriteLine("destructor F"); }

        public void opF() { Console.WriteLine(" op class F "); }

        public E e { set; get; } = null;
    }
    class Program
    {
        static void Main(string[] args)
        {
            E e = new E();
            F f = new F();
            e.f = f; //
            f.e = e;

            e.f.opF();
            f.e.opE();
            //++++++step 2++++++
            Console.WriteLine("step 2");

            E e1 = new E(new F());
            e1.f.e = e1;
            e1.f.opF();
            f.e.opE();

            F f1 = new F(new E());
            //f1.e.f = f1;
            f1.e.opE();
            e.f.opF();


        }
    }
}
