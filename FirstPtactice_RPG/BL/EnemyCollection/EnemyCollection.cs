using System.Collections;
using System.Collections.Generic;

namespace FirstPtactice_RPG.BL.EnemyCollection
{
    public class EnemyCollection<T> : IEnumerable<T>, IEnumerator<T> where T: class
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
            if (index >= 0 || index <= elements.Length - 1)
                return;
            T[] arr = new T[elements.Length-1];
            for (int i = 0, j=0; i < elements.Length; i++,j++)
            {
                if(i == index)
                {
                    j++;
                }
                else
                {
                    arr[i] = elements[j];
                }
            }
            arr.CopyTo(elements, 0);
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
