// See https://aka.ms/new-console-template for more information
// Create the implementation for the following class diagram using Abstract Factory pattern
using System;
using System.Text;
using System.Collections.Generic;
using Ex2_Animal;

namespace Ex2_Animal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Abstract Factory Pattern Demo***\n");
            var wildAnimalFactory = new WildAnimalFactory();
            // bug
            //var wildDog = wildAnimalFactory.GetDog();
           
            Console.WriteLine("Hello, World!");
        }

    }
    public class WildAnimalFactory
    {
        // bí ý tưởng mọe roi :)
    }public class PetAnimalFactory
    {
        // bí ý tưởng mọe roi :)
    }
    interface IDog
    {
        public class Action();
        public class Speak();
    }
    public class WildDog: IDog
    {
        public class Action();
        public class Speak();
    }
    public class PetDog: IDog
    {
        public class Action();
        public class Speak();
    }
    interface ITiger
    {
        public class Action();
        public class Speak();
    }
    public class WildTiger: ITiger
    {
        public class Action();
        public class Speak();
    }
    public class PetTiger: ITiger
    {
        public class Action();
        public class Speak();
    }
    interface IAnimalFactory
    {
        public class GetDog: IDog;
        public class GetTiger: ITiger;
    }
    public class WildFactory: IAnimalFactory
    {
        public class GetDog: IDog;
        public class GetTiger: ITiger;
    }
    public class PetFactory: IAnimalFactory
    {
        public class GetDog: IDog;
        public class GetTiger: ITiger;
    }

    
    

}
    
 