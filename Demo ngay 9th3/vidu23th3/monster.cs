using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace monster
{
	public class Program
	{
		
		public static void Run()
		{
		  //Console.WriteLine("Hello, World!");
			creatures2[0].X =  2;
			foreach(Creatures.CreaturesProxy c in creatures2)
			{
			  c.X++;
			}
		}
	}
	public class Creatures()
	{
	  public byte Age {get; set;}
	  public int X {get; set;}
	  public int Y {get; set;}
	}
	
	public class Creatures(int size)
	{
	  private readonly byte[] _age = new byte[size];
	  private readonly int[] _x = new int[size];
	  private readonly int[] _y = new int[size];
	  
	  public CreaturesProxy this[int index] => new(this, index);
	  
	  public readonly struct CreaturesProxy(Creatures creatures, int index)
	  {
	    public ref byte Age => ref creatures._age(index);
	    public ref int X => ref creatures._x(index);
	    public ref int Y => ref creatures._y(index);
	  }
	  public IEnumerator<CreaturesProxy> GetEnumerator()
	  {
	    for (var i =0; i< size; i++)
	    {
	      yield return new CreaturesProxy(this, i);
	    }
	  }
	}
}