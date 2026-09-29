using System;
namespace MyAvaloniaApp;
public class Calculation_ab
{
    private int a, b;

    public Calculation_ab()
    {
        a = 0;
        b = 0;
    }

    public Calculation_ab(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public Calculation_ab(int a)
    {
        this.a = a;
        this.b = 0;
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

    public long Product()
    {
        if (a > b)
            throw new ArgumentOutOfRangeException("a", "A should be less than or equal to B");

        long product = 1;
        bool found = false;

        for (int i = a; i <= b; i++)
        {
            if (i % 2 == 0 && i % 7 == 0)
            {
                product *= i;
                found = true;
            }
        }

        if (!found)
            return 0;

        return product;
    }
}