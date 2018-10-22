using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class DynamicArray<T>: IEnumerable<T> where T : new()
    {
        private T[] _array;
        private int _size = 0;

        public virtual int Length => _size;

        public virtual int Capacity
        {
            get
            {
                return _array.Length;
            }
            set
            {
                if (value < _size || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Argument out of range");
                }

                if (value != _array.Length)
                {
                    T[] newItems = new T[value];
                    if (_size > 0)
                    {
                        Array.Copy(_array, 0, newItems, 0, _size);
                    }
                    _array = newItems;
                }
            }
        }

        public virtual T this[int index]
        {
            get
            {
                if (index < 0 || index >= _size)
                {
                    throw new ArgumentOutOfRangeException("Argument out of range");
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= _size)
                {
                    throw new ArgumentOutOfRangeException("Argument out of range");
                }
                _array[index] = value;
            }
        }

        public DynamicArray()
        {
            _array = new T[8];
        }

        public DynamicArray(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Argument out of range. It must be non negative number");
            }
            _array = new T[number];
        }

        public DynamicArray(T[] items)
        {
            if (items == null)
            {
                throw new ArgumentNullException("Argument is null");
            }

            _array = new T[items.Length];
            Array.Copy(items, _array, items.Length);
            _size = items.Length;
        }

        ////// 
        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentException("Collection cannot be null");
            }

            _array = collection.ToArray();
            _size = collection.Count();
        }

        public virtual void Add(T value)
        {
            if (_size == _array.Length)
            {
                EnsureCapacity(_size + 1);
            }
            _array[_size] = value;
            _size++;
        }

        private void EnsureCapacity(int min)
        {
            if (_array.Length < min)
            {
                int newCapacity;
                if (_array.Length == 0)
                {
                    newCapacity = min;
                }
                else
                {
                    int multiply = min / _array.Length;
                    if (min % _array.Length > 0)
                    {
                        multiply++;
                    }
                    newCapacity = _array.Length * multiply;
                }

                Capacity = newCapacity;
            }
        }

        public virtual void AddRange(T[] items)
        {
            if (items == null)
            {
                throw new ArgumentNullException("Argument is null");
            }

            int count = items.Length;
            if (count > 0)
            {
                EnsureCapacity(_size + count);

                items.CopyTo(_array, _size);
                _size += count;
            }
        }

        public virtual bool Remove(T obj)
        {
            int index = Array.IndexOf((Array)_array, obj, 0, _size);

            if (index >= 0)
            {
                _size--;
                if (index < _size)
                {
                    Array.Copy(_array, index + 1, _array, index, _size - index);
                }
                _array[_size] = default(T);
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void Insert(int index, T value)
        {
            if (index < 0 || index > _size)
            {
                throw new ArgumentOutOfRangeException("Argument out of range");
            }
            if (_size == _array.Length)
            {
                EnsureCapacity(_size + 1);
            }
            if (index < _size)
            {
                Array.Copy(_array, index, _array, index + 1, _size - index);
            }
            _array[index] = value;
            _size++;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var el in this)
            {
                result.Append($"{el} ");
            }
            return result.ToString();
        }

        ////////////
        public IEnumerator<T> GetEnumerator()
        {
            T[] newArray = new T[Length];
            Array.Copy(_array, newArray, Length);
            return ((IEnumerable<T>)newArray).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)_array).GetEnumerator();
        }
    }
}
