using System;
using System.Collections;
//В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа,
//переберите данную коллекцию с помощью, цикла for. С какой проблемой вы столкнулись?

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(13);
            arrayList.Add("sun");
            arrayList.Add(16);
            arrayList.Add("star");

            for(int i=0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            // При печати на экран трудностей не возникает, но если работать с элементами
            // то нельзя предугадать какой тип будет следующий

            Console.WriteLine("Нажмите клавишу для выхода..");
            Console.ReadKey();
        }
    }
}
