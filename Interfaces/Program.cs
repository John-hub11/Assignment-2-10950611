using System;

// Interface IMovable with a method Move()
public interface IMovable
{
    void Move();
}

// Class Car that implements IMovable
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Class Bicycle that implements IMovable
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Car and Bicycle
        Car car = new Car();
        Bicycle bicycle = new Bicycle();

        // Call the Move() method on each instance
        car.Move();
        bicycle.Move();
    }
}
