using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int number = ReadNumber();

            Console.WriteLine("Enter desired index:");
            int index = ReadIndex();

            Console.WriteLine("Output (left to right): {0}", DigitAtIndexFromLeft(number, index));
            Console.WriteLine("Output (right to left): {0}", DigitAtIndexFromRight(number, index));
        }

        static int ReadNumber()
        {
            int number = 0;
            bool isNumber = false;

            while (isNumber == false || (number.ToString().Length > 7 || number.ToString().Length < 1))
            {
                isNumber = Int32.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }

        static int ReadIndex()
        {
            int index = 0;
            bool isNumber = false;

            while (isNumber == false)
            {
                isNumber = Int32.TryParse(Console.ReadLine(), out index);
            }

            return index;
        }

        static int DigitAtIndexFromLeft(int number, int index)
        {
            if (index <= number.ToString().Length && index >= 1)
            {
                return Int32.Parse(number.ToString()[--index].ToString());
            }

            return -1;
        }

        static int DigitAtIndexFromRight(int number, int index)
        {
            int numberLength = number.ToString().Length;

            if (index <= numberLength && index >= 1)
            {
                return Int32.Parse(number.ToString()[numberLength - index].ToString());
            }

            return -1;
        }
    }
}
