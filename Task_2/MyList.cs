using System;

namespace Task_2
{
    interface IMyList<T>
    {
        void Add(T t);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
    }
    class MyList<T> : IMyList<T>
    {
        private T[] array;
        public int Count { get { return array.Length; } } //свойство количества элементов
        public T this[int index] { get { return array[index]; } } //доступ по индексу
        public MyList()
        {
            array = new T[0];
        }
        public void Clear() { array = new T[0]; } //отчистка массива
        public void Add(T el)
        {
            Array.Resize(ref array, Count + 1);
            array[array.Length - 1] = el;
        }

    }
}
