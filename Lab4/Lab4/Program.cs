using System;

namespace Lab4
{
    interface A
    {
        void mA();
        int fA();
    }

    //СПЕЦИФИКАЦИЯ (наследование интерфейса и абстрактных функций)
    public class B : A
    {
        protected int b { get; set; }
        public int b1 { get; set; }

        public B() { 
            this.b = 1; 
            this.b1 = 4; 
        }
        ~B() { }
        public void mA() { Console.WriteLine(" метод mA интерфейса A "); }
        public int fA()
        {
            this.b += 1;
            //Console.WriteLine();
            return b;
        }
        public virtual int fB() { return 1; }
        public virtual void mB() { Console.WriteLine(" метод mB класса B "); }

    }

    //РАСШИРЕНИЕ 

    public class K : B
    {
        public int k1 { set; get; }
        public int k2 { set; get; }

        public K()
        {
            this.k1 = 3;
            this.k2 = 4;
        }

        ~K() { }

        public override int fB() //замещение 
        {
            Console.WriteLine(" Method of abstract class B in class K ");
            return this.k1 * this.k2 + base.fB();
        }

        public override void mB()
        {
            Console.WriteLine(" метод mB класса K");
        }

        public int fK() //новый метод в K
        {
            Console.WriteLine("Method of K");
            return this.k1 + this.k2;
        }
    }

    //абстрактный класс и у него есть конструктор но не можем создать объекты.
    //Например: нельзя сделать так: C c = new C();
    public abstract class C : A
    {
        protected int c1 { get; set; }
        protected int c2 { get; set; }

        public C()
        {
            this.c1 = 5;
            this.c2 = 6;
        }
        ~C() { }
        public void l() { Console.WriteLine(+50); }
        public void mA() { }
        public int fA() { return c1 + c2; }
        public abstract void mC();
        public abstract int fC();
        public virtual int pC() { return c1 * c2 - 10; }

    }

    public class F : C
    {
        public int f { get; set; }

        public F() { this.f = 20; }
        ~F() { }
        public new void l() { Console.WriteLine(+25); } // с помощью new мы скрываем метод базового класса
        public override void mC()
        {
            this.c1 = this.c1 + this.c2;
        }
        public override int fC()
        {
            Console.WriteLine("Function of F");
            return c1 + f;
        }
        public override int pC()
        {
            Console.WriteLine("function pC of class F");
            return c1 * c2 - f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new B();
            A a2 = new K();

            //спецификация 
            Console.WriteLine("Спецификация: ");
            Console.WriteLine("interface A a1.fA() = {0}", a1.fA());

            Console.WriteLine("Специализация:");
            C c1 = new F();
            F f = new F();
            c1.fC();
            f.fC();
            Console.WriteLine("Расширение: ");
            B b = new B();
            Console.WriteLine(" класс B функция b.fA = {0}", b.fA());
            Console.WriteLine(" класс B функция b.fB = {0}", b.fB());
            Console.WriteLine(" значение атрибута доступа b1 класса B = {0} ", b.b1);
            b.mB();
            b = new K();

            //расширение по функции
            // добавление новых методов в подкласс, а расширение по фунцкии - добавление новых алгоритмов
            Console.WriteLine(" класс K функция b.fB = {0} ", b.fB());
            b.mB();

            //конструирование
            // Это в другом классе создание одноимённой функции и она не является похожей на предыдущую
            // Это сокрытие фукнции базового класса и заменой её новой функцией в подклассе(наличие тех же параметров)

            Console.WriteLine(" Конструирование: ");
            C c = new F();
            c.l();
            F f1 = new F();
            f1.l();
            Console.WriteLine(" c = {0}", c.pC());

            Console.ReadKey();

        }
    }
}
