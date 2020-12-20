using System;

namespace FiboRec
{
    class Program
    {
        public static int Fibonacci (int n)
        {
            int a = 0;
            int b = 1;
            int i = 0;
            while(i < n)
            {
                int temp = a;
                a = b;
                b = temp + b;
                i++;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Количество подсчётов:");
            int some = int.Parse(Console.ReadLine());
            int i = 0;
            while(i < some)
            {
                Console.WriteLine(Fibonacci(i));
                i++;
            }
        }
    }
}
