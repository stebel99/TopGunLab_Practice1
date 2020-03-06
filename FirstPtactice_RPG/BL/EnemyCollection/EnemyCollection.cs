using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstPtactice_RPG.BL.EnemyCollection
{
    public class EnemyCollection<T> : IEnumerable<T>, IEnumerator<T> where T : class
    {
        private T[] elements = null;

        public EnemyCollection()
        {
            elements = new T[0];
        }
        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        public void Add(T elem)
        {
            T[] arr = new T[elements.Length + 1];
            elements.CopyTo(arr, 0);
            arr[elements.Length] = elem;
            elements = arr;
        }

        public void Remove(int index)
        {
            if (index >= Count())
            {
                return;
            }

            T[] newElements = new T[Count() - 1];
            for (int i = 0, j = 0; i < newElements.Length; i++, j++)
            {
                if (i==index)
                {
                    j++;
                }
                newElements[i] = elements[j];
            }
            elements = new T[newElements.Length];
            newElements.CopyTo(elements, 0);
            //int shiftStart = index + 1;
            //if (shiftStart < Count())
            //{
            //    // Shift all the items following index one slot to the left.
            //    Array.Copy(elements, shiftStart, elements, index, Count() - shiftStart);
            //}
        }
        public int Count()
        {
            int result = elements.Length;
            return result;
        }
        int position = -1;


        T IEnumerator<T>.Current
        {
            get { return elements[position]; }
        }

        object IEnumerator.Current
        {
            get { return elements[position]; }
        }

        public void Dispose()
        {
            ((IEnumerator)this).Reset();
        }

        bool IEnumerator.MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this;
        }
    }
}
