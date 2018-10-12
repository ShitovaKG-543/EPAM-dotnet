using System;

namespace Task2
{
    public class Ring
    {
        private Round _roundIn;
        private Round _roundOut;

        public Ring(double x, double y, double radiusIn, double radiusOut)
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

        public double RingSquare
        {
            get { return _roundOut.RoundSquare - _roundIn.RoundSquare; }
        }

        public double RingLength
        {
            get { return _roundIn.RoundLength + _roundOut.RoundLength; }
        }

        public override string ToString()
        {
            return $"X = {_roundIn.X}, Y = {_roundIn.Y}, Radius in = {_roundIn.Radius}, Radius out = {_roundOut.Radius}";
        }
    }
}
