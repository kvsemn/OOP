using System;

namespace Lab7
{
    class E // client
    {
        public E() { Console.WriteLine(" constructor E"); }
        ~E() { }
        public void op(F f) { Console.WriteLine(" op E"); //связаны через эту операцию
            f.op();
            Console.WriteLine($"{f.f + 5}");
            U.op1();
        }

    }

    class F // server
    {
        public F() { Console.WriteLine(" constructor F"); }
        ~F() { }
        public void op() { Console.WriteLine(" op F"); }
        public int f { set; get; } = 50;
    }

    static class U
    {
        public static void op() { Console.WriteLine(" op U"); }
        public static void op1() { Console.WriteLine(" op1 U"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            E e = new E();
            F f = new F();
            e.op(f);
                //
                U.op();
                U.op1();

        }
    }
}
