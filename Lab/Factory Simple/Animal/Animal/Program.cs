using System.Drawing;
using System;
using System.IO;
// 2/ Create the implementation for the following class diagram.

public class Program
{
    public static void Main()
    {
        // var animal1 = IAnimal();
        Console.WriteLine("Hello, World!");
    }
}
interface IAnimal
{
    public class Action() { }
    public class Speak() { }
}

class Tiger: IAnimal
{
    private class Action();
    private class Speak();
}
class Dog: IAnimal
{
    private class Action();
    private class Speak();
}

public abstract class AnimalFactory()
{
    public class CreateAnimal(string animalType): IAnimal
    {

    }
}
public class SimpleFactory(string animalType): IAnimal
{

}
