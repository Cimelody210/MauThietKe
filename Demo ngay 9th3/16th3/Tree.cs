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
			// Đốn dữ liệu lên 1tr dòng và pay màu
			
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
		  var forest = Enumerable.Range(0, 1000)
			  .Select(x, index) =>
			  {
			    var isApple = index % 3 ==0;
			    var treeType = TreeTypeFactory.Get(
			        isApple ? "Apple ": "Orange",
			        isApple ? "red ": "cyan",
			        isApple ? new string('a', 1000) : new string('b', 1000) );
			    
			    return new SmallType()
			    {
			      TreeType =  treeType,
			      X =  Random.Shared.Next(1,100),
			      Y =  Random.Shared.Next(1,100)
			    };
			  }.ToList();
		  
		  Assert.True(forest.Count >0);
		}
	}
}