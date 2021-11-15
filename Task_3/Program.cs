using System;
//Создайте класс Dictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность 
//использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен 
//System.Collections.Generic. Минимально требуемый интерфейс взаимодействия с экземпляром,
//должен включать метод добавления пар элементов, индексатор для получения значения элемента по 
//указанному индексу и свойство только для чтения для получения общего количества пар элементов. 

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Dictionary<int, string>();
            animal.Add(5, "dog");
            animal.Add(6, "cat");
            animal.Add(7, "rat");
            Console.WriteLine($"элемент с ключом 7 это {animal[7]}");
            Console.WriteLine("Всего элементов: " + animal.Count);

            Console.WriteLine("Нажмите клавишу для выхода..");
            Console.ReadKey();
        }
    }
}
