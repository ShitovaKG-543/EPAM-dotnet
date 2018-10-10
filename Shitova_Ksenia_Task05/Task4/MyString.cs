using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        private char[] _chars;

        public char[] Chars
        {
            get
            {
                return _chars;
            }
            set
            {
                _chars = value;
            }
        }

        public MyString(char[] chars)
        {
            Chars = chars;
        }

        public static MyString operator +(MyString str1, MyString str2)
        {
            char[] result = new char[str1.Chars.Length + str2.Chars.Length];
            str1.Chars.CopyTo(result, 0);
            str2.Chars.CopyTo(result, str1.Chars.Length);
            MyString myString = new MyString(result);
            return myString;
        }

        public static MyString operator -(MyString str1, MyString str2)
        {
            char[] result = new char[str1.Chars.Length + str2.Chars.Length];
            
            MyString myString = new MyString(result);
            return myString;
        }

        public static MyString operator !=(MyString str1, MyString str2)
        {
            char[] result = new char[str1.Chars.Length + str2.Chars.Length];
            
            MyString myString = new MyString(result);
            return myString;
        }

        public static MyString operator ==(MyString str1, MyString str2)
        {
            char[] result = new char[str1.Chars.Length + str2.Chars.Length];
            
            MyString myString = new MyString(result);
            return myString;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < Chars.Length; i++)
            {
                result.Append(Chars[i]);
            }
            return result.ToString();
        }
    }
}
