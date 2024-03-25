using System;
using System.Collection.Generic;
using System.Text;
using System.Xml.Linq;

public static class PointFactory
{
    public static void Run()
    {
        var p1= new Point(1,2);
        var p2= new Point(3,4);
        var p3= new Point(3,4,7);
        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
    //public record Point
    public class Point
    {
        protected Point(double r, double g){   X=r; y=g;}
        public Point(float r, float theta){
            X = r * Math.Cos(theta);
            Y = r * Math.Sin(theta);
        }
    }
    public double X(get;)
    public double Y(get;)

    public static Point NewCartesPoint(double x, double y)
    {
        return new Point(x,y);

    }
    public static Point NewPolarPoint(double alpha, double theta)
    {
        return new Point(alpha*Math.Cos(theta*(Math.PI/180), alpha*Math.Sin(theta*(Math.PI))));
    }

    public static class factory
    {
        // Exmaine code is here
    }
    


    
}
