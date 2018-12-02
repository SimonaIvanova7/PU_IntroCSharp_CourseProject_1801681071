using System;

namespace _220абв
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFirstExcercise();
            PrintSecondExcercise();
            PrintThirdExcercise();
        }

        static void PrintFirstExcercise()
        {
            Console.WriteLine("Excercise A: ");

            double firstAddend = CalculateSum(15, 1);
            double secondAddend = CalculateSum(10, 2);
            double denominator = CalculateSum(20, 1);

            Console.WriteLine(Calculate(firstAddend, secondAddend, denominator));
            Console.WriteLine();
        }

        static void PrintSecondExcercise()
        {
            Console.WriteLine("Excercise B: ");

            double firstAddend = CalculateSum(10, 1);
            double secondAddend = CalculateSum(10, 2);
            double denominator = CalculateSum(10, 3);

            Console.WriteLine(Calculate(firstAddend, secondAddend, denominator));
            Console.WriteLine();
        }

        static void PrintThirdExcercise()
        {
            Console.WriteLine("Excercise C: ");

            double firstAddend = CalculateSum(15, 1);
            double secondAddend = CalculateSum(10, 2);
            double denominator = CalculateSum(20, 3);

            Console.WriteLine(Calculate(firstAddend, secondAddend, denominator));
            Console.WriteLine();
        }

        static double Calculate(
            double firstAddend,
            double secondAddend,
            double denominator)
        {
            return (double)((firstAddend + secondAddend) / denominator);
        }

        static double CalculateSum(int iterations, int denominatorPower)
        {
            double result = 0;

            for (int i = 1; i <= iterations; i++)
            {
                result += (double)(1 / Math.Pow(i, denominatorPower));
            }

            return result;
        }
    }
}
