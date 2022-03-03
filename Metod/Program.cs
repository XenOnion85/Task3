using System;

namespace Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            Utils ut = new Utils();
            Console.WriteLine("Максимальное число: " + ut.Greater(a, b));
        }
    }
}
