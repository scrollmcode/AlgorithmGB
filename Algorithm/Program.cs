using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            F1(7);
            F1(8);
            F1(11);
            F1(17);
            F1(200);

            Console.WriteLine();

            Console.WriteLine(Fib(0));
            Console.WriteLine(Fib(1));
            Console.WriteLine(Fib(2));
            Console.WriteLine(Fib(3));
            Console.WriteLine(Fib(7));
            Console.WriteLine(Fib(10));
            Console.WriteLine(Fib(20));

            Console.WriteLine();

            Console.WriteLine(FibNR(0));
            Console.WriteLine(FibNR(1));
            Console.WriteLine(FibNR(2));
            Console.WriteLine(FibNR(3));
            Console.WriteLine(FibNR(7));
            Console.WriteLine(FibNR(10));
            Console.WriteLine(FibNR(20));

        }

        static void F1(int n)
        {
            int d = 0, i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }

                i++;
            }

            if (d == 0)
            {
                Console.WriteLine("Простое");
            }
            else
            {
                Console.WriteLine("Не простое");
            }

        }

        static int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        static int FibNR(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int one = 1, two = 1, tmp;

            for (int i = 2; i < n; i++)
            {
                tmp = one;
                one = two;
                two = tmp + two;
            }
            return two;
        }
    }
}
