using System;


interface IFigure
{
 int Dimension {get;set;}
 double Area();
 double Perimeter();
}
class Circle : IFigure      //Circle Implements IFigure
{
    public Circle()
    { }
    public Circle(int radius)
    {
        _Radius = radius;
    }
    private int _Radius;
    public int Dimension
    {
        get
        {
            return _Radius;
        }
        set
        {
            _Radius = value;
        }
    }
    public double Area()
    {
        return Math.PI * Dimension * Dimension;
    }
    public double Perimeter()
    {
        return 2 * Math.PI * Dimension;
    }
}
class Square : IFigure
{
    public Square()
    {
    }
    public Square(int side)
     {
        _Side = side;
     }
    private int _Side;
    public int Dimension
    {
        get
        {
            return _Side;
        }
        set
        {
            _Side = value;
        }
    }
    public double Area()
    {
        return Dimension * Dimension;
    }
    public double Perimeter()
    {
        return 4 * Dimension;
    }
}

class program
{
    static void Main(string[] args)
    {
        IFigure fig;
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide either C or S as command line arguments ");
            return;
        }
        if (args[0] == "C")
            fig = new Circle(10);
        else
            fig = new Square(10);
        Console.WriteLine(fig.Area());
        Console.WriteLine(fig.Perimeter());
    }
}