using System;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder resultString = new StringBuilder();
            int[,,] array = GetArray3DWithRandomValue(3, 3, 3, -50, 50);

            resultString.Append($"Initial array:\r\n{GetArrayToString(array)}");
            
            ReplaceArrayPositiveElementsWithZeros(ref array);

            resultString.Append($"Resulting array after replacing positive elements with zeros:\r\n{GetArrayToString(array)}");

            Console.WriteLine(resultString);
            Console.ReadLine();
        }

        public static int[,,] GetArray3DWithRandomValue(int numberElementsI, int numberElementsJ, int numberElementsK, int minValue, int maxValue)
        {
            Random rand = new Random();
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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
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
