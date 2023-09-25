using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание массива автомобилей
            Car[] cars = new Car[5];

            cars[0] = new Car("Toyota", "Camry", 2022, 25000, true);
            cars[1] = new Car("Honda", "Civic", 2021, 22000, true);
            cars[2] = new Car("Ford", "Mustang", 2020, 40000, false);
            cars[3] = new Car("Chevrolet", "Malibu", 2022, 23000, true);
            cars[4] = new Car("Nissan", "Altima", 2021, 24000, false);

            // Продажа автомобилей
            cars[0].Sell();
            cars[1].Sell();

            // Использование дополнительного метода
            cars[0].StartEngine();
            cars[0].Accelerate(); // Дополнительный метод из CarPartial.cs

            // Вывод общей статистики
            Console.WriteLine($"Всего продано автомобилей: {Car.GetTotalCarsSold()}");
            Console.WriteLine($"Общая выручка: {Car.GetTotalRevenue():C}");
            Console.ReadLine();
        }
    }

}
