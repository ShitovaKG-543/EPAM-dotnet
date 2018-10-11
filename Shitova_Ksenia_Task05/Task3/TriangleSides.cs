using System;

namespace Task3
{
    class TriangleSides
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get
            {
                return _a;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(A)} cannot be less than zero or equal to zero");
                }
                _a = value;
            }
        }

        public double B
        {
            get
            {
                return _b;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(B)} cannot be less than zero or equal to zero");
                }
                _b = value;
            }
        }

        public double C
        {
            get
            {
                return _c;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(C)} cannot be less than zero or equal to zero");
                }
                _c = value;
            }
        }

        public TriangleSides(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override string ToString()
        {
            return $"A = {A}, B = {B}, C = {C}";
        }
    }
}
