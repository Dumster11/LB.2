using System;

namespace number2
public class Rectangle
{
    double side1, side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double AreaCalculator()
    {
    
    }

    public double PerimeterCalculator()
    {
    
    }

    public double Area
    {
        get { return AreaCalculator(); }
    }

    public double Perimeter
    {
        get { return PerimeterCalculator(); }
    }
}

public Program
{
    static void Main(string[] args)
{
    var rectangle = new Rectangle(45.55, 66.54);
    Console.WriteLine("Area: {0}, Perimeter: {1}", rectangle.Area, rectangle.Perimeter);
    Console.ReadLine();
}
}
