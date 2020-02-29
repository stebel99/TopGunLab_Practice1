using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstPtactice_RPG.BL.EnemyCollection
{
    public class EnemyCollection<T> : IEnumerable<T>, IEnumerator<T>
    {
        readonly T[] elements = new T[10];

        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
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
