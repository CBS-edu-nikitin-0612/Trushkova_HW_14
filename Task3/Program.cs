// See https://aka.ms/new-console-template for more information
using Task3;

Console.WriteLine("Hello, World!");

Ship ship = new (100000, 1900, 20, "Корабль")
{    
    PortID = 123,
    CountOfPassangers = 1500,    
    X = 500000,
    Y = 7000000
};
ship.Show();

Car car = new (10000, 2022, 220, "Автомобиль")
{    
    X = 550000,
    Y = 7500000
};
car.Show();

Plane plane = new (1000000, 2010, 900, "Самолет")
{    
    X = 500000,
    Y = 7000000,
    Height = 10,
    CountOfPassangers = 200
};
plane.Show();


