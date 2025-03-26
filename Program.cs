using System;

abstract class Vehicle
{
    public string Name { get; set; }
    public double Speed { get; set; }
    public abstract void Move();
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Название: {Name}, Скорость: {Speed} км/ч");
    }
}

class Car : Vehicle
{
    public Car(string name, double speed)
    {
        Name = name;
        Speed = speed;
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} едет по дороге.");
    }
}

class Bicycle : Vehicle
{
    public Bicycle(string name, double speed)
    {
        Name = name;
        Speed = speed;
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} едет по тротуару.");
    }
}

class Boat : Vehicle
{
    public Boat(string name, double speed)
    {
        Name = name;
        Speed = speed;
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} плывёт по воде.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Car("Легковой автомобиль", 100);
        Vehicle bicycle = new Bicycle("Горный велосипед", 25);
        Vehicle boat = new Boat("Яхта", 40);
        car.DisplayInfo();
        car.Move();

        bicycle.DisplayInfo();
        bicycle.Move();

        boat.DisplayInfo();
        boat.Move();
    }
}