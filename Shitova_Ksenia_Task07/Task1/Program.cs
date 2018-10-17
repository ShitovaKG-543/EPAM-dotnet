using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Canvas canvas = new Canvas();
                canvas.AddFigure(new Line(12, 32, 12, 56));
                canvas.AddFigure(new Round(22, 33, 6));
                canvas.AddFigure(new Rectangle(12, 2, 43, 77));
                canvas.AddFigure(new Ring(4, 11, 5, 7));

                Console.WriteLine(canvas.DrawAll());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
