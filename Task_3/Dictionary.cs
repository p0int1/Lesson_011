using System;

namespace Task_3
{
    class Dictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] elements;
        int length = 0;

        public int Count { get { return length; } }

        public void Add(TKey ind, TValue el)
        {
            Array.Resize(ref keys, Count + 1);
            Array.Resize(ref elements, Count + 1);
            keys[elements.Length - 1] = ind;
            elements[elements.Length - 1] = el;
            length++;
        }

        public TValue this[TKey index]
        {
            get
            {
                int i = Array.IndexOf(keys, index);
                return elements[i];
            }
        }
    }
}
