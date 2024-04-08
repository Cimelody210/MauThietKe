using System.Drawing;
using System;
using System.IO;
using System.Runtime.InteropServices;

// 1 📝 Create the implementation for the following class diagram using Factory Method pattern

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("***Factory Method Pattern Demo***\n");

        // Creating a Tiger Factory
        var tigerFactory = new TigerFactory();


    }
}
interface IAnimal
{
    public void Action() { }
    public void Speak() { }
}

class Dog: IAnimal
{
    public void Action() { }
}
class Tiger: IAnimal
{
    public void Speak() { }
}

public class DogFactory()
{
    public class CreateAnimal(): IAnimal { }
}
public class TigerFactory()
{
    public class CreateAnimal(): IAnimal { }
}


// Introduce a new method called MakeAnimal
