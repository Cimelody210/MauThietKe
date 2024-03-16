using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;
using Xunit.Abstraction;

namespace Tree
{
	public class Tests
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			var list = 1;
		}

		public class TreeType()
		{
		  public string Name {get; set;}  
		  public string Color {get; set;}  
		  public string OtherTreeData {get; set;}  
		}
		public class SmallType()
		{
		  public TreeType treeType {get; set;}  
		  public int X {get; set;}  
		  public int Y {get; set;}  
		}
		
		public Tests(ITestOutputHelper output)
		{
		  _output=  output;
		  DotMemoryUnitsTestOutput.SetOutputMethod(_output.WriteLine);
		}
		private readonly ITestOutputHelper _output;
		[Fact]
		[DotMemoryUnit(FailIthoughtSupport= true)]
		public void TestForest1()
		{
		  var forest =1;
		}
	}
}