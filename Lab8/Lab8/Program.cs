using System;

namespace Lab8
{
    //шаблон
    class SwapT <T> // параметр T - можно подставить A , B и ...
    {
        public SwapT () { } 
        public void FSwap(ref T x, ref T y )
        {
            T t = x; // t - локальная ссылка
            x = y;
            y = t;
        }
    }
    class Swap
    {
        public Swap() { }
        public void FSwap(ref A x, ref A y)
        {
            A t = x; // t - локальная ссылка
            x = y;
            y = t;
        }
    }
    public interface IA
    {
        void F();
    }
    public interface IB
    {
        void Fb();
    }
    class D : IA
    {
        public void F() { Console.WriteLine("It is class D(IA)"); }
    }
    class U<T> where T : IA  //ограничение T
    {
        public T t { set; get; } //атрибут доступа, который создает атрибут
        public U(T t) //конкретизация конструктора
        {
            if (t is IA) //конкретизация с ограничениями 
            {
                Console.WriteLine(" yes IA");
                this.t = t;
            }
            else
                Console.WriteLine(" not IA");
        }
        public void F1() { Console.WriteLine("Hi"); }
        public void F() //конкретизация метода
        {
            Console.WriteLine(t is IA);
            Console.WriteLine(t); //имя объекта t
            if (t is IA)
            {
                IA ia = (IA)t;
                ia.F();
            }
            else Console.WriteLine(" false");
        }
    }
    class L <T1, T2> where T1: class //множественная конкретизация
                     where T2: class
    {
        public void f1(T1 t1, T2 t2)
        {
            Console.WriteLine(" Hi T1{0}, T2{1}", t1, t2);
        }
    }

    class A
    {

    }
    class B
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" step 1 ");
            A ax = new A();
            A ay = new A();
            Console.WriteLine("befor ax addr {0}", ax.GetHashCode().ToString()); //адрес объекта в памяти
            Console.WriteLine("befor ay addr {0}", ay.GetHashCode().ToString());

            Swap swap = new Swap();
            swap.FSwap(ref ax, ref ay);
            Console.WriteLine();
            Console.WriteLine("after ax addr {0}", ax.GetHashCode().ToString()); 
            Console.WriteLine("after ay addr {0}", ay.GetHashCode().ToString());

            Console.WriteLine();
            Console.WriteLine(" step 2 template <B>");

            B bx = new B();
            B by = new B();
            Console.WriteLine("befor bx addr {0}", bx.GetHashCode().ToString()); //адрес объекта в памяти
            Console.WriteLine("befor by addr {0}", by.GetHashCode().ToString());

            SwapT<B> swapt = new SwapT<B>(); // создание шаблона
            swapt.FSwap(ref bx, ref by);
            Console.WriteLine();
            Console.WriteLine("after bx addr {0}", bx.GetHashCode().ToString()); //адрес объекта в памяти
            Console.WriteLine("after by addr {0}", by.GetHashCode().ToString());

            Console.WriteLine();
            Console.WriteLine("step 2.1 <A>");

            SwapT<A> swapt_a = new SwapT<A>();
            swapt_a.FSwap(ref ax, ref ay);
            Console.WriteLine("after ax addr {0}", ax.GetHashCode().ToString());
            Console.WriteLine("after ay addr {0}", ay.GetHashCode().ToString());


            Console.WriteLine();
            Console.WriteLine(" step 3.1 U<D> D:IA ");
            D d1 = new D();
            U<D> u = new U<D>(d1);
            u.F();

            Console.WriteLine();
            Console.WriteLine(" step 3.2 L<T1, T2, ...> ");
            L<A, B> ol = new L<A, B>();
            ol.f1(ax, by);

            Console.WriteLine();
            Console.WriteLine(" step 3.3 - where ");
            U<D> u1 = new U<D>(d1);



        }
    }
}
