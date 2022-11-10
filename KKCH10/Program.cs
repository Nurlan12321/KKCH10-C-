using System;

namespace KKCH10
{
    class Program
    {
        static void Main(string[] args)
        {
        rec:
            Console.Clear();
            try
            {

                Console.WriteLine("Напишите число");
                Double A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{Math.Pow(A, 2)} " + $"{Math.Pow(A, 3)} " + $"{Math.Pow(A, 4)}");
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("Введите целое число");
                Console.ReadKey();
            }
            goto rec;
        }
    }
}