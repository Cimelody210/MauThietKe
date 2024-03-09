using System;
using System.IO;
using System.Data.Generic;
using System.Entity;
public static class Point
{
    public static void Run()
    {
        // examine
        // Add
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
