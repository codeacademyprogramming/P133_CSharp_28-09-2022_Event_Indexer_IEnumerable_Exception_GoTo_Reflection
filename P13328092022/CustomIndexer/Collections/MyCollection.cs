using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomIndexer.Collections
{
    class MyCollection<T> : IEnumerable  /*IEnumerable<T>*/ 
    {
        T[] arr;

        public T this[int index]
        {
            get 
            {
                if (index >= arr.Length || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Daxil Olunan Index Yanlisdir");
                }

                return arr[index];
            }
            set
            {
                if (index >= arr.Length || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Daxil Olunan Index Yanlisdir");
                }
                arr[index] = value;
            }
        }

        public MyCollection()
        {
            arr = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }

        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }

        //public IEnumerator<T> IEnumerable<T>.GetEnumerator()
        //{
        //    return arr.GetEnumerator<T>();
        //}
    }
}
