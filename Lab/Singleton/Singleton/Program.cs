// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Text;

namespace Singleton
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("1234");
            var s1 = Singleton.GetInstance();
            var s2 = Singleton.GetInstance();

            Console.WriteLine(s1 == s2
                ? "Singleton works, both variables contain the same instance."
                : "Singleton failed, variables contain different instances.");
        }
            
    }
    public class Singleton
    {
        private Singleton()
        {
            Console.WriteLine("Create Singleton");
        }
        private DateTime DateCreated { get; } = DateTime.Now;

        public override string ToString()
        {
            return DateCreated.ToString("O");
        }

        private static Singleton _instance;
        private static readonly object Lock = new();
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (Lock)
                {
                    _instance ??= new Singleton();
                }
            }
            return _instance;
        }
    }
}
