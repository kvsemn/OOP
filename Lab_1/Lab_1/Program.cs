using Lab_1;
using System;

namespace Lab_1
{
    class A
    {
        B b = null;
        C c = null;
        J j = null;

        public A(B b, C c, J j)
        {
            Console.WriteLine("Constructor A");
            this.b = b;
            this.c = c;
            this.j = j;
        }

        ~A() { }

        public void mA() { Console.WriteLine("  method of A"); }

        public B bA
        {
            set { Console.WriteLine("set b"); b = value; }
            get { Console.Write("get b ->"); return b; }
        }

        public C cA
        {
            set { Console.WriteLine("set c"); c = value; }
            get { Console.Write("get c ->"); return c; }
        }
        public J jA
        {
            set { Console.WriteLine("set j"); j = value; }
            get { Console.Write("get j ->"); return j; }
        }
    }

    class B
    {
        K k = null;
        D d = null;
        E e = null;

        /*public B(K k, D d, E e)
        {
            Console.WriteLine("Constructor B");
            this.k = k;
            this.d = d;
            this.e = e;
        }*/
        ~B() { }
        public void mB() { Console.WriteLine("  method of B"); }

        public K kA
        {
            set { Console.WriteLine("set k"); k = value; }
            get { Console.Write("get k -> "); return k; }
        }

        public D dA
        {
            set { Console.WriteLine("set d"); d = value; }
            get { Console.Write("get d -> "); return d; }
        }
        public E eA
        {
            set { Console.WriteLine("set e"); e = value; }
            get { Console.Write("get e -> "); return e; }
        }
    }
    class C
    {
        F f = null;

        public C(F f)
        {
            Console.WriteLine("Constructor F");
            this.f = f; 
        }
        ~C() { }
        public void mC() { Console.WriteLine("method of C"); }

        public F fA
        {
            set { Console.WriteLine("set f"); f = value; }
            get { Console.Write("get f ->"); return f; }
        }

    }
    class K
    {
        public K()
        {
            Console.WriteLine("Constructor K");
        }
        ~K() { }
        public void mK() { Console.WriteLine("  method of K"); }
    }
    class D
    {
        public D()
        {
            Console.WriteLine("Constructor D");
        }
        ~D() { }
        public void mD() { Console.WriteLine("  method of D"); }
    }
    class E
    {
        public E()
        {
            Console.WriteLine("Constructor E");
        }
        ~E() { }
        public void mE() { Console.WriteLine("  method of E"); }
    }
    class J
    {
        public J()
        {
            Console.WriteLine("Constructor J");
        }
        ~J() { }
        public void mJ() { Console.WriteLine("  method of J"); }
    }

    class F
    {
        public F()
        {
            Console.WriteLine("Constructor F");
        }
        ~F() { }
        public void mF() { Console.WriteLine(" method of F"); }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            F f = new F();
            K k = new K();
            D d = new D();
            E e = new E();
            J j = new J();
            C c = new C(f);
            //B b = new B(k, d, e);

            B b1 = new B();
            b1.kA = k;
            b1.dA = d;
            b1.eA = e;

            A a = new A(b1, c, j);

            a.mA();

            a.bA.mB();
            a.cA.mC();
            a.jA.mJ();

            a.bA.kA.mK();
            a.bA.dA.mD();
            a.bA.eA.mE();

            a.cA.fA.mF();

        Console.ReadKey();
        }
    }

