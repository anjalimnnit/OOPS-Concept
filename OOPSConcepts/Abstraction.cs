using System;
abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void AnimalSound();
    // Regular method
    public virtual void Sleep()
    {
        Console.WriteLine("Sleeping");
    }
}

// Derived class (inherit from Animal)
class Dog : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("My type is Golden Retreiver");
    }
    public override void Sleep()
    {
        Console.WriteLine("Dog is Sleeping");
    }
}
