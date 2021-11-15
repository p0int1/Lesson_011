using System;

namespace Task_2
{
    class CarCollection<T> : MyList<T>
    {
        private MyList<string> carName;
        private MyList<DateTime> carYear;
        public int Lenght { get { return carName.Count; } }
        public CarCollection() // конструктор класса создает два новых списка для названия и года
        {
            carName = new MyList<string>();
            carYear = new MyList<DateTime>();
        }
        public new string this[int index] // индексатор для доступа к элементам по номеру
        {
            get
            {
                return (index < carName.Count) ? $"{carName[index]}, {carYear[index].Year} года выпуска" 
                    : "нет машины под таким номером";
            }
        }
        public void AddCar(string name, DateTime year) // добавление в список автомобилей 
        {
            carName.Add(name);
            carYear.Add(year);
        }
        public void ClearCar() // отчистка массивов названия и года
        {
            carName.Clear();
            carYear.Clear();
        }
    }
}
