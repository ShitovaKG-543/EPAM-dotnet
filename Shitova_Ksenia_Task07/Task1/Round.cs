using System;

namespace Task1
{
    public class Round : Figure
    {
        private double _radius;
        
        public double Radius
        {
            get
            {
                return _radius;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Radius)} cannot be less than zero or equal to zero");
                }
                _radius = value;
            }
        }

        public Round(double x, double y, double radius): base(x, y)
        {
            Radius = radius;
        }

        public double RoundLength => 2 * Math.PI * Radius;
        
        public double RoundSquare => Math.PI * Math.Pow(Radius, 2);
       
        public override string Draw()
        {
            return $"{base.Draw()}, Radius = {Radius}";
        }
    }
}
