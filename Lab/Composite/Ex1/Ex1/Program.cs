
using System;
using System.IO;
using System.Data.Common;
using System.Text.RegularExpressions;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace Ex1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
        }
    }

    public interface Graphic
    {
        void move(int x, int y);
        void draw();
    }
    public abstract class Dot : Graphic
    {
        protected int x { get; set; }
        protected int y { get; set; }
        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public class Move(int x, int y) { 
            
        }
        public void draw() { }

        public abstract void move(int x, int y);
    }
    public class CompoundGraphic 
    {
        private readonly Graphic[] children;
        public void add(Graphic child) { }
        public void remove(Graphic child) { }
        public class Move(int x, int y)
        {

        }
        public void Draw() { }

    }
    public abstract class Circle
    {
        public double radius { get; set; }

        public Circle(int x, int y, double radius) { }

    
    }
}
