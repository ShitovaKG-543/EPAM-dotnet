using System;
using System.Text;

namespace Task2
{
    public class GeometricProgression: ISeries
    {
        double start, step;
        int currentIndex;

        public GeometricProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 0;
        }

        public double GetCurrent()
        {
            return start * Math.Pow(step, currentIndex);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
    }
}
