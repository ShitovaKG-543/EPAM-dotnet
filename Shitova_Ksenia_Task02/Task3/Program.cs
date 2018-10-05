using System;

namespace Task3
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
            string star = "*";

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + star);
                star += "**";
            }
            Console.ReadLine();
        }
    }
}
