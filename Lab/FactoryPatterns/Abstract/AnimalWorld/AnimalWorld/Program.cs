// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
namespace AnimalWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IContinentFactory continent = new AmericaFactory();
            AnimalWorld world = new AnimalWorld(continent);
            Console.WriteLine("Hello, World!");
        }
    }

    public abstract class Hebrivore
    {

    }
    public class Bison : Hebrivore { }
    public class Wildebesst : Hebrivore { }
    public class Deer : Hebrivore { }
    public abstract class Carnivore
    {
        public class Eats(Hebrivore hebrivore)
        {

        }
    }
    public class Wolf: Carnivore { }
    public class Lion: Carnivore { }
    public class Tiger: Carnivore { }
    
    interface IContinentFactory
    {
        public Hebrivore CreateHebrivore {  get;  }
        public Carnivore CreateCarnivore {  get;  }

    }
    public class Africafactory : IContinentFactory
    {
        public Hebrivore CreateHebrivore => throw new NotImplementedException();

        public Carnivore CreateCarnivore => throw new NotImplementedException();
    }
    public class AsiaFactory : IContinentFactory
    {
        public Hebrivore CreateHebrivore => throw new NotImplementedException();

        public Carnivore CreateCarnivore => throw new NotImplementedException();
    }
    public class AmericaFactory : IContinentFactory
    {
        public Hebrivore CreateHebrivore => throw new NotImplementedException();

        public Carnivore CreateCarnivore => throw new NotImplementedException();
    }
    public class AnimalWorld
    {
        private Carnivore _carnivore;
        private Hebrivore _hebrivore;
        private IContinentFactory continent;

        public void RunFoodChain()
        {
            //bug
            //_carnivore.Eats(_hebrivore);
        }

        // Bug
        public AnimalWorld(IContinentFactory continent)
        {
            this.continent = continent;
        }
    }

}
