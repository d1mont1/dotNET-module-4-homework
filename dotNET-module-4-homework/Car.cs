using System;

public partial class Car
{
    // Закрытые поля, представляющие характеристики автомобиля
    private string make;
    private string model;
    private int year;
    private double price;
    private bool isAvailable;

    // Статические поля
    private static int totalCarsSold;
    private static double totalRevenue;

    // Конструкторы
    public Car(string make, string model, int year, double price, bool isAvailable)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.price = price;
        this.isAvailable = isAvailable;
    }

    public Car(){ }// Конструктор по умолчанию

    
    static Car() // Статический конструктор
    {
        totalCarsSold = 0;
        totalRevenue = 0.0;
    }

    
    public string GetMake() // Методы доступа к закрытым полям
    {
        return make;
    }

    public void SetMake(string make)
    {
        this.make = make;
    }

    public double GetPrice()
    {
        return price;
    }

    public void SetPrice(double price)
    {
        if (price >= 0)
        {
            this.price = price;
        }
        else
        {
            Console.WriteLine("Цена не может быть отрицательной.");
        }
    }

    
    public void Sell() // Метод управления классом
    {
        if (isAvailable)
        {
            Console.WriteLine($"Продан {make} {model} за {price:C}");
            totalCarsSold++;
            totalRevenue += price;
            isAvailable = false;
        }
        else
        {
            Console.WriteLine($"Автомобиль {make} {model} уже продан.");
        }
    }

    // Метод, принимающий аргументы по ссылке
    public void UpdateYear(ref int newYear)
    {
        year = newYear;
    }

    // Статические поля доступа
    public static int GetTotalCarsSold()
    {
        return totalCarsSold;
    }

    public static double GetTotalRevenue()
    {
        return totalRevenue;
    }
}

// Дополнительный метод для класса Car, используя partial
partial class Car
{
    public void StartEngine()
    {
        Console.WriteLine($"Двигатель автомобиля {make} {model} запущен.");
    }
}

