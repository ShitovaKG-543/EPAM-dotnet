using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User("sdfjhw", "ssij", "fhrg", new DateTime(1997, 9, 6));
                Console.WriteLine(user);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
