using System;
using System.Collections.Generic;

namespace Task1
{
    class MyStringArray
    {
        private List<string> _strings = new List<string>();

        public int Length => _strings.Count;

        public virtual string this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new ArgumentOutOfRangeException("Argument out of range");
                }
                return _strings[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new ArgumentOutOfRangeException("Argument out of range");
                }
                _strings[index] = value;
            }
        }

        public void Add(string str)
        {
            _strings.Add(str);
        }

        public static bool CompareStringLength(string s1, string s2)
        {
            return s1.Length == s2.Length;
        }

        public static bool LengthComparer(string str1, string str2)
        {
            return str1.Length > str2.Length;
        }

        public static bool AlphabetComparer(string str1, string str2)
        {
            return str1.CompareTo(str2) == 1;
        }

        public static bool AscendingComparer(string str1, string str2)
        {
            if (CompareStringLength(str1, str2))
            {
                return AlphabetComparer(str1, str2);
            }
            else
            {
                return LengthComparer(str1, str2);
            }
        }

        public void Sort(Func<string, string, bool> methodSort)
        {
            for (int i = 0; i < _strings.Count; i++)
            {
                for (int j = i + 1; j < _strings.Count; j++)
                {
                    if (methodSort(_strings[i], _strings[j]))
                    {
                        var temp = _strings[i];
                        _strings[i] = _strings[j];
                        _strings[j] = temp;
                    }
                }
            }
        }
    }
}
