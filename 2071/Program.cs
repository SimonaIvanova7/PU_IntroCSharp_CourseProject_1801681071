using System;

namespace _2071
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 2071;
            Console.WriteLine($"Стойността, която ще се конвертира е: {value}");
            string binary = Convert.ToString(value, 16);
            string binary2 = Convert.ToString(value, 8);           
            string binary3 = Convert.ToString(value, 2);
            Console.WriteLine($"Стойността на {value} в 16-тична броична система е: {binary}");
            Console.WriteLine($"Стойността на {value} в 8-ична броична система е: {binary2}");
            Console.WriteLine($"Стойността на {value} в 2-ична броична система е: {binary3}");


        }
    }
}
