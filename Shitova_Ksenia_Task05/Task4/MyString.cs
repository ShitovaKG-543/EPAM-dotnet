﻿using System;
using System.Text;

namespace Task4
{
    public class MyString
    {
        private char[] _chars;

        public char this[int n] {
            get { return Chars[n]; }
            set
            {
                Chars[n] = value;
            }
        }

        private char[] Chars
        {
            get
            {
                return _chars;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException($"Entered string cannot be null");
                }
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
            str1.Chars = str1.ToString().Replace( str2.ToString(), "").ToCharArray();
            return str1; 
        }

        public static bool operator !=(MyString str1, MyString str2)
        {
            return !(str1 == str2);
        }

        public static bool operator ==(MyString str1, MyString str2)
        {
            return (str1.GetHashCode() == str2.GetHashCode());
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
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
