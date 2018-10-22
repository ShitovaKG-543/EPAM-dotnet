using System;

namespace Task3
{
    public class Words : IComparable<Words>
    {
        private string _word;
        private int _number;

        public string Word
        {
            get
            {
                return _word;
            }

            set
            {
                _word = value;
            }
        }

        public int Number
        {
            get
            {
                return _number;
            }

            set
            {
                _number = value;
            }
        }

        public Words(string word, int number)
        {
            Word = word;
            Number = number;
        }

        public override string ToString()
        {
            return string.Format("________________________\n| {0,-13}| {1,-7}|\n", Word, Number);
        }

        public int CompareTo(Words other)
        {
            return other.Number - Number;
        }
    }
}
