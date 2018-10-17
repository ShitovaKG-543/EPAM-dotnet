
namespace Task3
{
    public class ArithmeticalProgression : ISeries, IIndexable
    {
        double start, step;
        int currentIndex;
        private int _length;

        public ArithmeticalProgression(double start, double step, int length)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 1;
            _length = length;
        }

        public int GetLength() => _length;

        public double GetCurrent()
        {
            return start + step * currentIndex;
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

        public double this[int index]
		{
			get
			{
				return start + step * index;
			}
		}
    }
}
