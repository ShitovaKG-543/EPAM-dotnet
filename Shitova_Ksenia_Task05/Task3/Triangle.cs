using System;

namespace Task3
{
    class Triangle
    {
        private TriangleSides _sides;

        public TriangleSides Sides
        {
            get
            {
                return _sides;
            }
            set
            {
                if (value.A + value.B > value.C && value.A + value.C > value.B && value.C + value.B > value.A)
                {
                    _sides = value;
                }
                else
                {
                    throw new ArgumentException($"{nameof(Sides)} cannot contain sides, the sum of two of which is less than the third");
                }
            }
        }

        public double GetTrianglePerimeter()
        {
            return Sides.A + Sides.B + Sides.C;
        }

        public double GetTriangleSquare()
        {
            double halfPerimeter = GetTrianglePerimeter() / 2;
            double square = Math.Sqrt(halfPerimeter * (halfPerimeter - Sides.A) * (halfPerimeter - Sides.B) * (halfPerimeter - Sides.C));
            return square;
        }

    }
}
