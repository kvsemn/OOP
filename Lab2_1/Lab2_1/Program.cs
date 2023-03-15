using System;

namespace Lab_2
{

    class A
    {
        B b = new B();
        C c = new C();
        J j = new J();

        public A() { }
        ~A() { }

        public void mA() { Console.WriteLine("method of A"); }

        public B bA { get { Console.Write("get b ->"); return b; } }
        public C cA { get { Console.Write("get c ->"); return c; } }
        public J jA { get { Console.Write("get j ->"); return j; } }
    }

    class B
    {
        K k = new K();
        D d = new D();
        E e = new E();

        public B() { }

        ~B() { }
        public void mB() { Console.WriteLine("  method of B"); }
        public K kA { get { Console.Write("get k -> "); return k; } }
        public D dA { get { Console.Write("get d -> "); return d; } }
        public E eA { get { Console.Write("get e ->"); return e; } }
    }

    class C
    {
        F f = new F();

        public C() { }
        ~C() { }
        public void mC() { Console.WriteLine("method of C"); }

        public F fA
        {
            get { Console.Write("get f ->"); return f; }
        }
    }

    class D
    {
        public D() { }
        ~D() { }
        public void mD() { Console.WriteLine(" method of D"); }
    }

    class E
    {
        public E() { }
        ~E() { }
        public void mE() { Console.WriteLine(" method of E"); }
    }

    class F
    {
        public F() { }
        ~F() { }
        public void mF() { Console.WriteLine(" method of F"); }
    }

    class J
    {
        public J() { }
        ~J() { }
        public void mJ() { Console.WriteLine(" method of J"); }
    }

    class K
    {
        public K() { }
        ~K() { }
        public void mK() { Console.WriteLine(" method of K"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
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
}