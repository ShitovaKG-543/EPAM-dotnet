using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "disposable_task_file.txt";

            try
            {
                string[] dataFile = File.ReadAllLines(filename);

                for (int i = 0; i < dataFile.Length; i++)
                {
                    int number;
                    if (int.TryParse(dataFile[i], out number))
                    {
                        dataFile[i] = Math.Pow(number, 2).ToString();
                    }
                }

                File.WriteAllLines(filename, dataFile);

                Console.WriteLine("The program completed successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred during the operation of the program:");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
