using System;

namespace Task1
{
    public class Ring : Figure 
    {
        private Round _roundIn;
        private Round _roundOut;

        public Ring(double x, double y, double radiusIn, double radiusOut) : base(x, y)
        {
            if (radiusIn > radiusOut)
            {
                throw new ArgumentException($"Round in cannot be more than radius out");
            }
            else
            {
                _roundIn = new Round(x, y, radiusIn);
                _roundOut = new Round(x, y, radiusOut);
            }
        }

        public double RadiusIn
        {
            get
            {
                return _roundIn.Radius;
            }
        }

        public double RadiusOut
        {
            get
            {
                return _roundOut.Radius;
            }
        }

        public double RingSquare => _roundOut.RoundSquare - _roundIn.RoundSquare;

        public double RingLength => _roundIn.RoundLength + _roundOut.RoundLength;

        //public override string Draw()
        //{
        //    return $"{base.Draw()}, Radius in = {RadiusIn}, Radius out = {RadiusOut}";
        //}
    }
}
