using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee("sdad","sdf","ds",new DateTime(2018,4,21), 3, "khk");
            try
            {
                Console.WriteLine(empl.Equals(null));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
