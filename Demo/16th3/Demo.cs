using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Demo
{
	internal class Program
	{
		public static void Main(string[] args)
		{
		  var hole = new RoundHole(8);
		  var peg1 = new RoundHole(6);
		  var peg2 = new RoundHole(4);
		  if (peg1.Fits(hole))
		  {
		    Console.WriteLine('Peg1 fits hole')
		  }
		  if (peg2.Fits(hole))
		  {
		    Console.WriteLine('Peg2 fits hole')
		  }
		  var squarePeg = new SquarePeg(10);
		  var adapter = new SquareAdapter(squarePeg);
		  adapter.fits(hole);
		  
		// 	Console.WriteLine("Hello, World!");
		}
	}
	public class RoundHole
	{
	  public RoundHole(float radius)
	  {
	    Radius = radius;
	  }
	  public float Radius {get; set;}
	  public bool Fits(RoundHole hole)
	  {
	    return Radius <= hole.Radius;
	  }
	}
	
	public class SquarePeg: RoundHole
	{
	  public SquarePeg SquarePeg {get; set;}
	  public SquareAdapter(float radius): base(radius)
	  {
	    SquarePeg =  squarePeg;
	    // here is code
	  }
	  public override bool Fits(RoundHole hole)
	  {
	    // Đường chéo hình chữ nhật
	    var d = Math.Sqrt(2*SquarePeg.Side * SquarePeg.Side);
	    return base.Fits(hole);
	  }
	}
	public class SquarePeg
	{
        ///
	  
	}
}