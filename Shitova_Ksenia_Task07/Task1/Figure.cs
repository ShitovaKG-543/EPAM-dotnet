
namespace Task1
{
    public abstract class Figure
    {
        private double _x;
        private double _y;
        
        public double X
        {
            get
            {
                return _x;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }
        }

        public Figure(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public void Draw(IPrinter printer)
        {
            printer.Print(X, Y);
        }

        //public virtual string Draw()
        //{
        //    return $"Тип фигуры: {GetType().Name}, координаты X = {X}, Y = {Y}";
        //}
    }
}
