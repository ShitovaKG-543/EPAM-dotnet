using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first string: ");
            string initialString1 = Console.ReadLine();
            Console.Write("Enter the secong string: ");
            string initialString2 = Console.ReadLine();

            string initialString2WithoutRepeat = GetStringWithoutRepeat(initialString2);
            DoubleString1CharactersBelongingToString2(ref initialString1, initialString2WithoutRepeat);

            Console.WriteLine($"Resulting string: {initialString1}");
            Console.ReadLine();
        }

        public static string GetStringWithoutRepeat(string initialString)
        {
            string initialStringWithoutRepeat = String.Empty;
            for (int i = 0; i < initialString.Length; i++)
            {
                if (!initialStringWithoutRepeat.Contains(initialString[i]))
                {
                    initialStringWithoutRepeat += initialString[i];
                }
            }
            return initialStringWithoutRepeat;
        }

        public static void DoubleString1CharactersBelongingToString2(ref string string1, string string2)
        {
            for (int i = 0; i < string2.Length; i++)
            {
                string1 = string1.Replace(string2[i].ToString(), new string(string2[i], 2));
                //for (int j = 0; j < string1.Length; j++)
                //{
                //    if (string1[j].Equals(string2[i]))
                //    {
                //        string1 = string1.Insert(j + 1, string2[i].ToString());
                //        j++;
                //    }
                //}
            }
        }

    }
}
