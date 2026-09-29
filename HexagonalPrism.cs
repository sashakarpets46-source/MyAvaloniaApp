using System;
namespace MyAvaloniaApp;
public class HexagonalPrism
{
    private double a, h;

    public HexagonalPrism()
    {
        a = 0;
        h = 0;
    }

    public HexagonalPrism(double a, double h)
    {
        this.a = a;
        this.h = h;
    }

    public HexagonalPrism(double a)
    {
        this.a = a;
        this.h = 0;
    }

    public double A
    {
        get;
        set;
    }

    public double H
    {
        get;
        set;
    }

    public double Volume()
    {
        return (3 * Math.Sqrt(3) / 2) * a * a * h;
    }

    public double LateralSurfaceArea()
    {
        return 6 * a * h;
    }

    public double TotalSurfaceArea()
    {
        return LateralSurfaceArea() + 2 * (3 * Math.Sqrt(3) / 2) * a * a;
    }
}