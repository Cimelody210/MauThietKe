using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Composite;

namespace XElement
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  GeometricShapes.Run()
		  var doc = new XDocument();
		  doc.Add(
		    new XElement("Drawing",
		      new XElement("Circle", new XAttribute("Color", "Red")),
		      new XElement("Square", new XAttribute("Color", "Lime"));
  		    new XElement("Group",
  		      new XElement("Circle", new XAttribute("Color", "Red")),
  		      new XElement("Square", new XAttribute("Color", "Lime"));
  		    )
		    )
            )
		};
			Console.WriteLine(doc);
	}
}