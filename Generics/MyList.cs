using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sensey.Generics
{

    public class MyList<T>
    {
        private T[] _mainArr = new T[8];
        private int _count = 0;
        private int _sizeToExpand = 8;
        private int _currentIndex= 0;
        public void Add(T value)
        {
            if (_count >= _mainArr.Length)
            {
                _mainArr = ResizeArray(_mainArr);
            }
            _mainArr[_count] = value;
            _count++;
           
        }

        public void AddRange(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Add(arr[i]);
            }
        }

        public void Remove(T value)
        {
            T[] newArr = new T[_mainArr.Length - 1];
            int j = 0;
            bool numberFoundInList = false;

            for (int i = 0; i < _mainArr.Length; i++)
            {
                if (_mainArr[i] is not null && !_mainArr[i].Equals(value))
                {
                    if (j < _mainArr.Length - 1)
                    {
                        newArr[j] = _mainArr[i];
                        j++;
                    }
                }
                else
                {
                    numberFoundInList = true;
                }
            }

            if (numberFoundInList)
            {
                _mainArr = newArr;
            }
        }
        public void RemoveRange(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Remove(arr[i]);
            }
        }

        public void RemoveAt(int index)
        {
            T removableValue = Get(index);
            Remove(removableValue);
        }
        public T Get(int index)
        {
            return _mainArr[index];
        }

        public void Insert(int index, T value)
        {
            if (index > _count)
            {
                throw new IndexOutOfRangeException();
            }
            _mainArr[index] = value;
        }


        public void Print(MyList<T> list)
        {
            for (int i = 0; i < _mainArr.Length; i++)
            {
                Console.WriteLine(list.Get(i));
            }
        }

        private T[] ResizeArray(T[] initialArray)
        {
            T[] newArray = new T[initialArray.Length + _sizeToExpand];

            if (initialArray.Length >= newArray.Length)
            {
                throw new Exception("New Array's array Length should be bigger than initial's.");
            }

            for (int i = 0; i < initialArray.Length; i++)
            {
                newArray[i] = initialArray[i];
            }

            return newArray;
        }

        public void PrintCurrent()
        {
            Console.WriteLine(_mainArr[_currentIndex]);
            IncrementCurrentIndex();

        }

        public bool HasNext()
        {
            if(_currentIndex < _count)
            {
                return true;
            }
            else
            {
                ResetIndex();
            }

            return false;
        }

        private void ResetIndex()
        {
            _currentIndex = 0;
        }

        private void IncrementCurrentIndex()
        {
            _currentIndex++;
        }

    }
}
