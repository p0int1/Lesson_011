using System;
//Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность 
//использования его экземпляра для создания парка машин. Минимально требуемый интерфейс 
//взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и года 
//ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство только для 
//чтения для получения общего количества элементов.
//Создайте метод удаления всех машин автопарка.

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var salon = new CarCollection<string>();

            salon.AddCar("Ваз", new DateTime(1995, 1, 1));
            salon.AddCar("Тойота", new DateTime(2010, 1, 1));
            salon.AddCar("Шкода", new DateTime(2013, 1, 1));
            salon.AddCar("Форд", new DateTime(2005, 1, 1));
            salon.AddCar("Ланос", new DateTime(2007, 1, 1));

            Console.WriteLine($"В салоне находится: {salon.Lenght} машин.");

            Console.Write("Введите номер машины: ");
            string numbStr = Console.ReadLine();

            if (!Int32.TryParse(numbStr, out int number))
            {
                Console.WriteLine("Вы ввели не числовое значение.");
            }
            else
            {
                Console.WriteLine(salon[number - 1]);
            }

            Console.WriteLine("Нажмите клавишу для выхода..");
            Console.ReadKey();
        }
    }
}
