using System;

namespace Task2
{
    public class Round
    {
        private double _x;
        private double _y;
        private double _radius;

        public double X
        {
            get
            {
                return _x;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(X)} cannot be less than zero or equal to zero");
                }
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Y)} cannot be less than zero or equal to zero");
                }
                _y = value;
            }
        }

        public double Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Radius)} cannot be less than zero or equal to zero");
                }
                _radius = value;
            }
        }

        public Round(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public double RoundLength
        {
            get { return 2 * Math.PI * Radius; }
        }

        public double RoundSquare
        {
            get { return Math.PI * Math.Pow(Radius, 2); }
        }


        //public double GetRoundLength()
        //{
        //    return 2 * Math.PI * Radius;
        //}

        //public double GetRoundSquare()
        //{
        //    return Math.PI * Math.Pow(Radius, 2);
        //}

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, Radius = {Radius}";
        }
    }
}
