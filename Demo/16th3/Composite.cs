using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Composite
{
	public static class GeometricShapes
	{
		public static void Main(string[] args)
		{
		  var drawing =  new GraphObject(Name = "Group by Drawing");
		  
		  var group = new GraphObject();
		  group.Children.Add( new Square {Color = "Cyan"});
		  group.Children.Add( new Circle {Color = "Yellow"});
		  
			Console.WriteLine(drawing);
		}
		public class GraphObject
		{
		  public string Name {get; set;} = "Group";
		  public string Color {get; set;}
		  public List<GraphObject> Children {get;} = new();
		  
		  private void Print(StringBuilder sb, int depth)
		  {
		    sb.Append(new string('*',depth))
		      .Append(string.IsNullOrWhiteSpace(Color) ? " ": ${Color})
		      .AppendLine(Name);
		    foreach(var child in Children)
		    {
		      child.Print(sb, depth+1);
		    }
		  }
		}
		public override string ToString(){}
		
	}
}