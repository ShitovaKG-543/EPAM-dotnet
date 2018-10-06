using System;
using System.Text;

namespace Task4
{
    class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            StringBuilder resultString = new StringBuilder();
            int[,] array = GetArray2DWithRandomValue(rand, 5, 5, -50, 50);
            if (array.Length != 0)
            {
                resultString.Append($"Initial array:\r\n{GetArray2DToString(array)}\r\n");
                resultString.Append($"Sum of elements standing at even places: {GetElementsSumStandingAtEvenPlaces(array)}");
            }
            else
            {
                resultString.Append("Array is empty");
            }
            Console.WriteLine(resultString);
            Console.ReadLine();
        }

        public static int GetElementsSumStandingAtEvenPlaces(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i,j];
                    }
                }
            }
            return sum;
        }

        public static int[,] GetArray2DWithRandomValue(Random rand, int numberElementsI, int numberElementsJ, int minValue, int maxValue)
        {
            int[,] array = new int[numberElementsI, numberElementsJ];
            for (int i = 0; i < numberElementsI; i++)
            {
                for (int j = 0; j < numberElementsJ; j++)
                {
                    array[i, j] = rand.Next(minValue, maxValue);
                }
            }
            return array;
        }

        public static string GetArray2DToString(int[,] array)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result.Append($"{array[i, j],4} ");
                }
                result.Append("\r\n");
            }
            return result.ToString();
        }
    }
}
