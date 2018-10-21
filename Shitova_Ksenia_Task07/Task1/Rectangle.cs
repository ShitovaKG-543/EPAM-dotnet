using System;

namespace Task1
{
    public class Rectangle : Figure
    {
        private double _length;
        private double _width;

        public double Length
        {
            get
            {
                return _length;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be less than zero or equal to zero");
                }
                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be less than zero or equal to zero");
                }
                _width = value;
            }
        }

        public Rectangle(double x, double y, double length, double width) : base(x, y)
        {
            Length = length;
            Width = width;
        }

        //public override string Draw()
        //{
        //    return $"{base.Draw()}, Length = {Length}, Width = {Width}";
        //}
    }
}
