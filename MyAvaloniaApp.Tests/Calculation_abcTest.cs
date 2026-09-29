using MyAvaloniaApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyAvaloniaApp.Tests;

[TestClass]
public sealed class Calculation_abcTest
{
    [TestMethod]
    public void Test_Average()
    {
        Calculation_abc calculation = new Calculation_abc(10, 20, 30);

        double result = calculation.D();

        Assert.AreEqual(20.0, result);
    }

    [TestMethod]
    public void Test_B_Less_Than_15()
    {
        Calculation_abc calculation = new Calculation_abc(20, 10, 30);

        double result = calculation.D();

        Assert.AreEqual(20.0, result);
    }

    [TestMethod]
    public void Test_C_Less_Than_15()
    {
        Calculation_abc calculation = new Calculation_abc(20, 30, 10);

        double result = calculation.D();

        Assert.AreEqual(20.0, result);
    }

    [TestMethod]
    public void Test_Sum()
    {
        Calculation_abc calculation = new Calculation_abc(20, 30, 40);

        double result = calculation.D();

        Assert.AreEqual(90.0, result);
    }

    [TestMethod]
    public void Test_ZeroConstructor()
    {
        Calculation_abc calculation = new Calculation_abc();

        double result = calculation.D();

        Assert.AreEqual(0.0, result);
    }

    [TestMethod]
    public void Test_TwoParameterConstructor()
    {
        Calculation_abc calculation = new Calculation_abc(10, 20);

        double result = calculation.D();

        Assert.AreEqual(10.0, result);
    }
}