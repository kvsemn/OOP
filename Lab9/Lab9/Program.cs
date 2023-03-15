using System;

namespace Lab9
{
    //step 1
    
    delegate void B();
    delegate int A(int x, int y); //делегат - множество сигнатур
    class Program
    {
        
        static void Main(string[] args)
        {
            // step 2
            B b = delegate() { //b - указатель
                Console.WriteLine(" +++ ");
                Console.WriteLine(" B b = delegate()"); 
            }; 
            b();
            b.Invoke();  //
            b = delegate ()
            {
                Console.WriteLine(" mail ");
            };
            B b1 = delegate ()
            {
                Console.WriteLine(" google");
            };
            b(); b1();
            Console.WriteLine(" b += b1");
            b += b1;
            b();
            b -= b1;
            Console.WriteLine(" b -= b1");
            b();

            b += new B(A); //Создание с помощью конструктора
            b();
            ///////////////////////step 3 //////////////////////
            B p = delegate ()
            {
                Console.WriteLine();
                Console.WriteLine("next step");
            };
            p();
            A a = new A(Add); // 1 способ
            a(2, 4);
            p();
            a.Invoke(4,5);
            p();

            A a1 = null; // 2 способ
            a1 = Add;
            a1.Invoke(1, 1);
            a1 = Sub;
            p();
            a1(3, 4);
            p();

            int result = a1(3, 4);
            Console.WriteLine(" result = {0} ", result);
            p();
            a1 += Add;
            result = a1(2, 2);
            Console.WriteLine(" result = {0} ", result);

            p();
            a1 += Dev;
            result = a1(6, 3);
            Console.WriteLine(" result = {0} ", result);
            p();
            MultiCast(Add, 4);
            MultiCast(Sub, 5);
            MultiCast(Dev, 3);

            p();
            a1 -= Add;
            a1 -= Dev;
            MultiCast(a1, 2);

        }
        static void A() { Console.WriteLine(" static void A()"); }

        private static int Add(int x1, int y1) // сигнатура соответствует 
        {

            Console.WriteLine("Add ");
            return x1 + y1;
        }
        private static int Sub(int x2, int y2) // сигнатура соответствует
        {

            Console.WriteLine("Sub ");
            return x2 - y2;
        }
        private static int Dev(int x3, int y3)
        {

            Console.WriteLine("Dev ");
            return x3 / y3;
        }

        private static void MultiCast(A a, int c)
        {
            int result = a(c,c*10);
            Console.WriteLine("MultiCast {0}", result);
        }
    } //end
}
