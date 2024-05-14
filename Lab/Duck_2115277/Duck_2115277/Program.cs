using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Duck_2115277
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("2115277 - Nguyễn Trung Tín");
            SimulateDucks();
            SimulateWithDecorator();
        }
        private static void SimulateDucks()
        {
            Console.WriteLine("Duck Simulator");

            var mallardDuck = new MallardDuck();
            var redheadDuck = new RedheadDuck();
            var duckCall = new DuckCall();
            var rubberDuck = new RubberDuck();

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
        }
        private static void SimulateWithDecorator()
        {
            Console.WriteLine("Duck Simulator: With Composite - Flocks");

            var mallardDuck = new QuackCounter(new MallardDuck());
            var redheadDuck = new QuackCounter(new RedheadDuck());
            var duckCall = new QuackCounter(new DuckCall());
            var rubberDuck = new QuackCounter(new RubberDuck());

            // Other code...
            Console.WriteLine(mallardDuck);
            Console.WriteLine(redheadDuck);
            Console.WriteLine(duckCall);
            Console.WriteLine(rubberDuck);
            //Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacks} times");
        }

        private static void SimulateWithComposite(AbstractDuckFactory duckFactory)
        {
            Console.WriteLine("Duck Simulator: With Composite");

            // Code to create ducks
            var duck1 = new DuckCall();

            var goose = new Goose();
            var flockOfDucks = new Flock();

            Simulate(flockOfDucks);
        }
        private static void SimulateWithObserver(AbstractDuckFactory duckFactory)
        {
            Console.WriteLine("Duck Simulator: With Observer");
            var duck1 = new DuckCall();

            // Code to create ducks

            var flockOfDucks = new Flock();


            IObserver quackologist = new Quackologist();
            quackologist.Subscribe(flockOfDucks);

            Simulate(flockOfDucks);
        }

        private static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
    public interface IQuackable
    {
        void Quack();
    }
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack quack!");
            //throw new NotImplementedException();
        }
    }
    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack quack!");
            throw new NotImplementedException();
        }
    }
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
            throw new NotImplementedException();
        }
    }
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
            throw new NotImplementedException();
        }
    }
    // 3
    // DO NOT change this class
    public class Goose
    {
        public void Honk()
        {
            Console.WriteLine("Honk");
        }
    }
    public class GooseAdapter : IQuackable
    {
        public GooseAdapter(Goose goose)
        {

        }
        public void Quack()
        {
            //throw new NotImplementedException();
        }

    }

    //4 Create a decorator QuackCounter  to add a new behavior (counting) to the
    //ducks. Achieve this by wrapping them with the decorator, without altering the existing Duck code
    public class QuackCounter : IQuackable
    {
        private int numberofQuack;
        public int GetQuacks { get; private set; }
        public QuackCounter(IQuackable duck)
        {
            if (duck != null)
            {
                numberofQuack++;
            }
        }
        public void Quack()
        {
            //throw new NotImplementedException();
        }
    }

    // 5 Enhance the current code by applying the Singleton pattern with a
    // lazy-loaded singleton class named QuackStore
    public class QuackStore
    {
        public required QuackStore Instance;
        public int NumberOfStacks;
    }

    // Create 2 derived classes for the class AbstractDuckFactory
    public abstract class AbstractDuckFactory : IQuackable
    {
        public abstract void Quack();

        public required IQuackable CreateMallardDuck;

    }
    public class DuckFactory : AbstractDuckFactory
    {

        public override void Quack()
        {
            throw new NotImplementedException();
        }
    }
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override void Quack()
        {
            //throw new NotImplementedException();
        }
    }
    // 9 Apply the Composite pattern to introduce a new derived class named Flock
    public class Flock : IQuackable, IObservable
    {
        private readonly IObservable _observable = new Observable();
        private List<IQuackable>? quacker = new();
        public class Add(IQuackable quacker)
        {
            public IQuackable Quacker { get; } = quacker;
        }
        public void Quack()
        {
            throw new NotImplementedException();
        }

        public void Attach(IObserver observer)
        {
            throw new NotImplementedException();
        }
        public void Notify()
        {
            throw new NotImplementedException();
        }
    }

    public interface IObserver
    {
        void Subscribe(IObservable observable);
        void Update(IObservable subject);
    }

    public interface IObservable
    {
        void Attach(IObserver observer);
        void Notify();
    }

    public class Observable : IObservable
    {
        // implement this
        public void Attach(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }

    public class Quackologist : IObserver
    {
        public void Subscribe(IObservable observable)
        {
            // implement this
        }

        public void Update(IObservable subject)
        {
            // print $"Quackologist: {subject} just quacked."
        }
    }




}
