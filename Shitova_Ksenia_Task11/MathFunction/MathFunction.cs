namespace MathLibrary
{
    public class MathFunction
    {
        public static ulong Factorial(ulong n)
        {
            if (n == 0)
                return 1;
            return Factorial(n - 1) * n;
        }

        public static double Pow(double x, double y)
        {
            return System.Math.Pow(x, y);
        }
    }
}
