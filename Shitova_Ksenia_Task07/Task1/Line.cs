using System;

namespace Task1
{
    public class Line : Figure
    {
        private double _x2;
        private double _y2;

        public double X2
        {
            get
            {
                return _x2;
            }
        }

        public double Y2
        {
            get
            {
                return _y2;
            }
        }

        public Line(double x1, double y1, double x2, double y2) : base(x1, y1)
        {
            _x2 = x2;
            _x2 = y2;
        }

        public double Length => Math.Sqrt(Math.Pow(Math.Abs(X2 - X), 2) + Math.Pow(Math.Abs(Y2 - Y), 2));
        
        //public override string Draw()
        //{
        //    return $"{base.Draw()}, X2 = {X2}, Y2 = {Y2}";
        //}
    }
}
