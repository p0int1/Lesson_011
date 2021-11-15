using System;
//Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его 
//экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();

            myList.Add(7);
            myList.Add("Man");
            myList.Add(3.17);
            myList.Add(true);

            for (int i = 0; i < myList.Count; i++)
                Console.WriteLine(myList[i]);

            Console.WriteLine("Нажмите клавишу для выхода..");
            Console.ReadKey();
        }
    }
}
