namespace MyAvaloniaApp;

public class Calculation_abc
{
    private int a, b, c;

    public Calculation_abc()
    {
        a = 0;
        b = 0;
        c = 0;
    }

    public Calculation_abc(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public Calculation_abc(int a, int b)
    {
        this.a = a;
        this.b = b;
        this.c = 0;
    }

    public int A
    {
        get;
        set;
    }

    public int B
    {
        get;
        set;
    }

    public int C
    {
        get;
        set;
    }

    public double D()
    {
        if (a < 15 || b < 15 || c < 15)
            return (a + b + c) / 3.0;
        else
            return a + b + c;
    }
}