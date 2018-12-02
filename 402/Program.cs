using System;
using System.Threading;

namespace _402
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month length: ");
            int daysInMonth = ReadDaysOfMonth();

            int[] A = PopulateStation(daysInMonth);
            int[] B = PopulateStation(daysInMonth);
            int[] C = PopulateStation(daysInMonth);

            PrintStationStats(A);
            PrintStationStats(B);
            PrintStationStats(C);
        }

        static void PrintStationStats(int[] station)
        {
            int lowestRainfall = CalculateLowestRainfall(station);
            int[] daysOfOccurance = GetLowestRainfallDays(station, lowestRainfall);

            Console.WriteLine("Lowest rainfall: {0}", lowestRainfall);
            Console.Write("Occurred on days:");

            for (int i = 0; i < daysOfOccurance.Length; i++)
            {
                Console.Write(" {0}", daysOfOccurance[i]);
            }

            Console.WriteLine();
            Console.WriteLine("==========");
        }

        static int CalculateLowestRainfall(int[] station)
        {
            int lowestRainfall = Int32.MaxValue;

            for (int i = 0; i < station.Length; i++)
            {
                if (station[i] > 0 && station[i] < lowestRainfall)
                {
                    lowestRainfall = station[i];
                }
            }

            return lowestRainfall;
        }

        static int[] GetLowestRainfallDays(int[] station, int lowestRainfall)
        {
            string occurences = "";

            for (int i = 0; i < station.Length; i++)
            {
                if (station[i] == lowestRainfall)
                {
                    occurences += String.Format(" {0}", i + 1);
                }
            }

            string[] occurenceArr = occurences.Trim(' ').Split(' ');
            int[] result = new int[occurenceArr.Length];

            for (int i = 0; i < occurenceArr.Length; i++)
            {
                result[i] = int.Parse(occurenceArr[i]);
            }

            return result;
        }

        static int ReadDaysOfMonth()
        {
            int daysOfMonth = 0;
            bool isNumber = false;

            while (isNumber == false || (daysOfMonth > 31 || daysOfMonth < 1))
            {
                isNumber = Int32.TryParse(Console.ReadLine(), out daysOfMonth);
            }

            return daysOfMonth;
        }

        static int[] PopulateStation(int daysInMonth)
        {
            int[] station = new int[daysInMonth];

            Random rand = new Random();
            for (int i = 0; i < daysInMonth; i++)
            {
                int litersPerCubicMeter = rand.Next(0, 101);
                Thread.Sleep(20);
                station[i] = litersPerCubicMeter;
            }

            return station;

        }
    }
}
