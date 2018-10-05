using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Введите стороны прямоугольника a и b");

            while (!int.TryParse(Console.ReadLine(), out a) || !int.TryParse(Console.ReadLine(), out b) || a <= 0 || b <= 0)
            {
                Console.WriteLine("Ошибка. Введите еще раз.");
            }

            Console.WriteLine($"Площадь прямоугольника равна {a * b}");
            Console.ReadLine();
        }
    }
}
