using System;

namespace _368
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three-digit number:");

            string number = Console.ReadLine();

            Console.WriteLine(StringifyNumber(number));
        }

        static string StringifyNumber(string number)
        {
            string result = "";
            result = EvaluateHundreds(result, number);
            result = EvaluateDecimals(result, number);
            result = EvaluateDigits(result, number);

            return result;
        }

        static string EvaluateHundreds(string accumulator, string number)
        {
            int digit = int.Parse(number[0].ToString());
            string suffix = "стотин";

            switch (digit)
            {
                case 0: return accumulator;
                case 1: return "сто";
                case 2: return GetDigitString(digit) + "ста";
                case 3: return GetDigitString(digit) + "ста";
                default:
                    return GetDigitString(digit) + suffix;
            }
        }

        static string EvaluateDecimals(string accumulator, string number)
        {
            int digit = int.Parse(number[1].ToString());
            int nextDigit = int.Parse(number[2].ToString());

            string suffix = "десет";
            string runningResult = "";

            switch (digit)
            {
                case 0: break;
                case 1: runningResult = HandleDecimalExceptions(accumulator, nextDigit); break;
                case 2: runningResult = "два" + suffix; break;
                default:
                    runningResult = GetDigitString(digit) + suffix;
                    break;
            }

            if (nextDigit == 0)
            {
                return accumulator + " и " + runningResult;
            }

            return accumulator + " " + runningResult;
        }

        static string EvaluateDigits(string accumulator, string number)
        {
            int digit = int.Parse(number[2].ToString());
            int prev = int.Parse(number[1].ToString());

            bool shouldContinue = prev != 1;
            if (shouldContinue)
            {
                string joint = digit == 0 ? " " : " и ";
                return accumulator + joint + GetDigitString(digit);
            }

            return accumulator;
        }

        static string HandleDecimalExceptions(string accumulator, int nextDigit)
        {
            switch (nextDigit)
            {
                case 1: return ComposeDecimalException(accumulator, "еди");
                case 2: return ComposeDecimalException(accumulator, "два");
                default:
                    return ComposeDecimalException(accumulator, GetDigitString(nextDigit));
            }
        }

        static string ComposeDecimalException(string accumulated, string digit)
        {
            string prefix = "и ";
            string suffix = "надесет";

            return String.Format("{0}{1}{2}", prefix, digit, suffix);
        }

        static string GetDigitString(int digit)
        {
            switch (digit)
            {
                case 1: return "едно";
                case 2: return "две";
                case 3: return "три";
                case 4: return "четири";
                case 5: return "пет";
                case 6: return "шест";
                case 7: return "седем";
                case 8: return "осем";
                case 9: return "девет";
                default: return "";
            }
        }
    }
}