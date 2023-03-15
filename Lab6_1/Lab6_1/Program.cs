using System;
//1:N
namespace Lab6_1
{
    class E
    {
        public E() { Console.WriteLine("Constructor E");
            this.f = new F[N];
        }

        ~E() { Console.WriteLine("destructor E"); }

        public void opE() { Console.WriteLine(" op class E "); }

        public int N { set; get; } = 4;
        F[] f = null;
        int size = 0;

        public F fA
        {
            set
            {
                if (size < N)
                {
                    this.f[size] = value;
                    size++;
                }
                else Console.WriteLine("size>=N");
            }
            get
            {
                if (this.size != 0)
                    return this.f[--size];
                else
                    return null;
            }
        }
    }

    class F
    {
        public F() { Console.WriteLine("Constructor F"); }
        public F(E e)
        {
            Console.WriteLine("Constructor F(E e)");
            this.e = e;
        }
        ~F() { Console.WriteLine("destructor F"); }

        public void opF() { Console.WriteLine(" op class F "); }

        public E e { set; get; } = null;
    }
    class Program
    {
        static void Main(string[] args)
        {
            E e = new E();  // 1

            F f = new F();  // 3
            F f1 = new F();
            F f2 = new F();
            
            e.fA = f; //  1:3     1:N
            e.fA = f1;
            e.fA = f2;

            f.e = e;
            f1.e = e;
            f2.e = e;

            e.fA.opF();
            e.fA.opF();
            e.fA.opF();

            f.e.opE();
            f1.e.opE();
            f2.e.opE();


        }
    }
}
