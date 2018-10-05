using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите число N");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Ошибка. Введите еще раз.");
            }
           
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i));
            }
            Console.ReadLine();
        }
    }
}
