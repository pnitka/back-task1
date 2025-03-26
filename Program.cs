using System;

abstract class Vehicle
{
    public string Name { get; set; }
    public double Speed { get; set; }
    public abstract void Move();
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Название: {Name}, cкорость: {Speed} км/ч");
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
        Vehicle car = new Car("ллегковой автомобиль", 100);
        Vehicle bicycle = new Bicycle("горный велосипед", 25);
        Vehicle boat = new Boat("яхта", 40);
        car.DisplayInfo();
        car.Move();

        bicycle.DisplayInfo();
        bicycle.Move();

        boat.DisplayInfo();
        boat.Move();
    }
}
