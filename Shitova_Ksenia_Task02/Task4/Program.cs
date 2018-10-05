using System;

namespace Task4
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
                GetTriangle(i, n);
            }
           
            Console.ReadLine();
        }

        public static void GetTriangle(int nStar, int nSpace)
        {
            string star = "*";
            for (int i = 0; i < nStar; i++)
            {
                Console.WriteLine(new string(' ', nSpace - i) + star);
                star += "**";
            }
        }
    }
}
