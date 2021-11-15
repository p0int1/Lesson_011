using System;

namespace Task_4
{
    class ArrayList
    {
        object[] array;

        public int Count //свойство получения размера
        {
            get { return array.Length; }
        }

        public ArrayList() //конструктор класса
        {
            array = new object[0];
        }

        public void Clear() //обнуление коллекции
        {
            array = new object[0];
        }

        public void Add(object element) //добавление элемента
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = element;
        }

        public object this[int index] //индексатор для доступа
        {
            get { return array[index]; }
        }
    }
}
