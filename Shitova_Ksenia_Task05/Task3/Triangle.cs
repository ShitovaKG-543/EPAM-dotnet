using System;

namespace Task3
{
    public class Triangle
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

        public Triangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && c + b > a)
            {
                ;
            }
            else
            {
                throw new ArgumentException($"Triangle cannot contain sides, the sum of two of which is less than the third");
            }
        }

        public double GetTrianglePerimeter()
        {
            return A + B + C;
        }

        public double GetTriangleSquare()
        {
            double halfPerimeter = GetTrianglePerimeter() / 2;
            double square = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
            return square;
        }

        public override string ToString()
        {
            return $"A = {A}, B = {B}, C = {C}";
        }
    }
}
