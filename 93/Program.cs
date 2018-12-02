using System;

namespace _93
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            int pr = n;
            for (int i = 1; i < k; i++)
            {
                pr *= (n - i * k);
            }
            Console.WriteLine("n(n-k)(n-2k)...(n-k*k)=" + pr);
        }
    }
}

