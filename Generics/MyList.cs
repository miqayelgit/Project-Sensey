using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sensey.Generics
{

    public class MyList<T>
    {
        private static T[] mainArr = new T[10];
        private int Index = 0;
        private int SizeToExpand = 5;
        public void Add(T value)
        {
            if (Index >= mainArr.Length)
            {
                mainArr = ResizeArray(mainArr);
            }
            mainArr[Index] = value;
            Index++;
           
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
            T[] newArr = new T[mainArr.Length - 1];
            int j = 0;
            bool numberFoundInList = false;

            for (int i = 0; i < mainArr.Length; i++)
            {
                if (mainArr[i] is not null && !mainArr[i].Equals(value))
                {
                    if (j < mainArr.Length - 1)
                    {
                        newArr[j] = mainArr[i];
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
                mainArr = newArr;
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
            return mainArr[index];
        }

        public void Insert(int index, T value)
        {
            if (index > Index)
            {
                throw new IndexOutOfRangeException();
            }
            mainArr[index] = value;
        }


        public static void Print(MyList<T> list)
        {
            for (int i = 0; i < mainArr.Length; i++)
            {
                Console.WriteLine(list.Get(i));
            }
        }

        private T[] ResizeArray(T[] initialArray)
        {
            T[] newArray = new T[initialArray.Length + SizeToExpand];

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

    }
}
