using System;
using System.IO;
using System.Data.Common;

namespace Exercises1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hole = new RoundHole(5);
            var rpeg = new RoundPeg(5);
            Console.WriteLine(rpeg);
            Console.WriteLine(hole);
            Console.WriteLine("Example of Adapter in square and circle");

        }
    }
    public class RoundHole
    {
        public int Radius { get; set; }
        public RoundHole(int radius)
        {
            Radius = radius;

        }
        public bool Fits(RoundHole peg)
        {
            return true;
        }
    }
    public class RoundPeg
    {
        public int Radius { get; set; }
        public RoundPeg(int radius)
        {
            Radius = radius;
        }
    }
    public class SquarePegAdapter: RoundPeg
    {
        private SquarePeg peg;
        public int getRadius
        {
            get { return (int)(peg.Width * Math.Sqrt(2) / 2); }
        }
    

        public SquarePegAdapter(SquarePeg peg): base(peg.Width)
        {
            this.peg = peg;
        }

    }
    public class SquarePeg
    {
        public int Width { get; set; }

    
        public SquarePeg(int width)
        {
            width = Width;
        }

        public double CaculateArea()
        {
            return Width * Width;
        }
    }
}

