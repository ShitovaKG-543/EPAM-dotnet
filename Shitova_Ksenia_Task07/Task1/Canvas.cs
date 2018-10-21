using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Canvas
    {
        private List<Figure> _figures;

        public Canvas()
        {
            _figures = new List<Figure>();
        }

        public void AddFigure(Figure figure)
        {
            _figures.Add(figure);
        }
        
        public void DrawAll(IPrinter printer)
        {
            StringBuilder result = new StringBuilder();
            foreach (Figure figure in _figures)
            {
                figure.Draw(printer);
            }
        }

        
    }
}
