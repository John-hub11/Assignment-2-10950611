using System;

// Base class Animal with a method MakeSound()
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog that overrides the MakeSound() method
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat that overrides the MakeSound() method
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Animal, Dog, and Cat
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Call the MakeSound() method on each instance
        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();
    }
}