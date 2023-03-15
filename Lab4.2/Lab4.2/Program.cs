using System;

namespace Lab4._2
{

    class Program
    {
        interface F
        {
            void mf();
            int Ff();
        }
        interface B : F
        {
            void mb();
            int Fb();
        }
        class C : F
        {
            protected int c { get; set; }
            public C() { this.c = 2; Console.WriteLine(" Constructor C "); }
            ~C() { }
            public virtual void mf() { Console.WriteLine(" method F of class C "); }
            public virtual int Ff() { return this.c = this.c + 1; }
            public virtual void Fc() { Console.WriteLine(" Fucntion of class C "); }

        }
        class A : C, B
        {
            protected int a { get; set; }
            public A() { this.a = 3; Console.WriteLine(" Constructor A "); }
            ~A() { }
            public void mb() { Console.WriteLine(" Method B of class A "); }
            public int Fb() { return this.a = this.a + 2; }
            public override void Fc() { Console.WriteLine(" Fucntion of class C in class A "); }
            public override void mf() { Console.WriteLine(" method F of class A "); }
            public override int Ff() { return this.a + 5; }
         }
static void Main(string[] args)
        {
            F f = null;
            f = new C();
            Console.WriteLine(" f.Ff ={0}", f.Ff());
            f.mf();
            Console.WriteLine();
            f = new A();
            Console.WriteLine(" f.Ff ={0}", f.Ff());
            f.mf();
            Console.WriteLine();
            A a = new A();
            a.mf();
            a.Fc();
            Console.WriteLine();
            B b = null;
            b = new A();
            b.mb();

            Console.WriteLine(" b.Fb() ={0}", b.Fb());
            Console.ReadKey();
        }
    }
}
