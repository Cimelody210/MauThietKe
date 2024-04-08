// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
        var p1 = new Point(12, 5);
        var p2 = new Point(13, 22.6);
        var p3 = new Point(13, 22.6, CoordinateSystem.Polar);
    }
}
public enum CoordinateSystem
{
    Polar,
    Cartesian
}

public class Point
{
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Point(float r, float theta)
    {
        X = r * Math.Cos(theta);
        Y = r * Math.Sin(theta);
    }

    public Point(double a, double b, CoordinateSystem cs)
    {
        switch (cs)
        {
            case CoordinateSystem.Polar:
                X = a * Math.Cos(b);
                Y = a * Math.Sin(b);
                break;
            case CoordinateSystem.Cartesian:
                X = a;
                Y = b;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(cs), cs, null);
        }
    }

    public double X { get; }
    public double Y { get; }
}

