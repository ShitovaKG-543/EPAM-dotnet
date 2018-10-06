using System;
using System.Text;

namespace Task2
{
    class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            StringBuilder resultString = new StringBuilder();
            int[,,] array = GetArray3DWithRandomValue(rand, 3, 3, 3, -50, 50);

            if (array.Length != 0)
            {
                resultString.Append($"Initial array:\r\n{GetArrayToString(array)}");
                ReplaceArrayPositiveElementsWithZeros(ref array);
                resultString.Append($"Resulting array after replacing positive elements with zeros:\r\n{GetArrayToString(array)}");
            }
            else
            {
                resultString.Append("Array is empty.");
            }

            Console.WriteLine(resultString);
            Console.ReadLine();
        }

        public static int[,,] GetArray3DWithRandomValue(Random rand, int numberElementsI, int numberElementsJ, int numberElementsK, int minValue, int maxValue)
        {
            int[,,] array = new int[numberElementsI, numberElementsJ, numberElementsK];
            for (int i = 0; i < numberElementsI; i++)
            {
                for (int j = 0; j < numberElementsJ; j++)
                {
                    for (int k = 0; k < numberElementsK; k++)
                    {
                        array[i, j, k] = rand.Next(minValue, maxValue);
                    }
                }
            }
            return array;
        }

        public static void ReplaceArrayPositiveElementsWithZeros(ref int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
        }

        public static string GetArrayToString(int[,,] array)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        result.Append($"{array[i, j, k], 4} ");
                    }
                    result.Append("\r\n");
                }
                result.Append("\r\n");
            }
            return result.ToString();
        }
    }
}
