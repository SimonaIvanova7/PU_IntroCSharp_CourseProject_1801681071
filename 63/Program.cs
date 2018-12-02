using System;

namespace _63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equation 1: y = 6,7 + 9k");
            Console.WriteLine("Equation 2: y = 6,7 + 9k + 7k^2");
            Console.Write("Enter value for 'k': ");
            Console.WriteLine();

            double k = ReadCoeficient();

            Console.WriteLine();
            Console.WriteLine("Solving y = 6,7 + 9*{0}", k);
            Console.WriteLine("Result: y = {0}", CalculateLinear(k));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Solving y = 6,7 + 9*{0} + 7*{0}^2", k);
            Console.WriteLine("Result: y = {0}", CalculateQuadratic(k));
            Console.WriteLine();
        }

        static double CalculateLinear(double k)
        {
            return 6.7 + (9 * k);
        }

        static double CalculateQuadratic(double k)
        {
            return 6.7 + (9 * k) + (7 * Math.Pow(k, 2));
        }

        static double ReadCoeficient()
        {
            double coeficient = 0.0;
            bool isNumber = false;

            while (isNumber == false)
            {
                isNumber = Double.TryParse(Console.ReadLine(), out coeficient);

                if (isNumber == false)
                {
                    Console.WriteLine("Value must be a valid real number!");
                }
            }

            return coeficient;
        }
    }
}
