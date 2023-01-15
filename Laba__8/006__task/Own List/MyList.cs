using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _006__task.Own_List
{
    internal class MyList<T> : IEnumerable, IEnumerator where T : IComparable
    {
        private int count = 0;
        private int position = -1;
        private int positionForEneter = -1;
        public int Count { get => this.count; }

        T[] mass = new T[1];
        public void Clear()
        {
            this.count = 0;
            this.position = -1;
            this.mass = new T[1];
        }
        public void AddElement(T element)
        {
            this.count++;
            Array.Resize(ref mass, count);
            this.positionForEneter++;
            this.mass[positionForEneter] = element;
        }
        public void RemoverElement(int index)
        {
            for (int i = index; i < count - 1; i++)
            {
                mass[i] = mass[i + 1];
            }
            Array.Resize(ref mass, mass.Length - 1);
        }
        public bool FindElement(T element)
        {
            foreach (var value in mass)
            {
                if (value.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        public int GetComparable(T value)
        {
            int result = 0;
            foreach (var element in mass)
            {
                if (value.CompareTo(element) < 0)
                    result++;
            }
            return result;
        }
        public T MaxElement()
        {
            return this.mass.Select(x => x).Max();
        }
        public T MixElement()
        {
            return this.mass.Select(x => x).Min();
        }
        public bool MoveNext()
        {
            position++;
            return (position < mass.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        public T Current
        {
            get
            {
                return this.mass[position];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return mass.GetEnumerator();
        }
        public T this[int index]
        {
            get => mass[index];
            set => mass[index] = value;
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
        public override string ToString()
        {
            var Builder = new StringBuilder();
            foreach (var element in mass)
            {
                Builder.Append(" " + element + " ");
            }
            return Builder.ToString();
        }
    }
}
