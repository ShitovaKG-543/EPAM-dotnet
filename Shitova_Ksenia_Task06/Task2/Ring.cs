using System;

namespace Task2
{
    public class Ring: Round
    {
        private double _radiusIn;

        public double RadiusIn
        {
            get
            {
                return _radiusIn;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(RadiusIn)} cannot be less than zero or equal to zero");
                }
                _radiusIn = value;
            }
        }

        public Ring(double x, double y, double radiusOut, double radiusIn) : base(x, y, radiusOut)
        {
            if (radiusIn > radiusOut)
            {
                throw new ArgumentException($"Round in cannot be more than radius out");
            }
            else
            {
                RadiusIn = radiusIn;
            }
        }
        
        public double RingSquare
        {
            get { return base.RoundSquare - Math.PI * Math.Pow(RadiusIn, 2); }
        }

        public double RingLength
        {
            get { return base.RoundLength + 2 * Math.PI * RadiusIn; }
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, Radius in = {RadiusIn}, Radius out = {Radius}";
        }
    }
}
