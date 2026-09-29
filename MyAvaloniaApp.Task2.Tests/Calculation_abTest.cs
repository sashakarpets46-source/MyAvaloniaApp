using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAvaloniaApp;

namespace MyAvaloniaApp.Task2.Tests;

[TestClass]
public class Calculation_abTest
{
    [TestMethod]
    public void Calculation_a_great_b()
    {
        Calculation_ab calculation = new Calculation_ab(2, 1);

        try
        {
            calculation.Product();
            Assert.Fail("Очікувалася помилка");
        }
        catch (ArgumentOutOfRangeException)
        {
            return;
        }
    }

    [TestMethod]
    public void Calculation_a_equal_b()
    {
        Calculation_ab calculation = new Calculation_ab(1, 1);

        long result = calculation.Product();

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Calculation_positive_numbers()
    {
        Calculation_ab calculation = new Calculation_ab(1, 15);

        long result = calculation.Product();

        Assert.AreEqual(14, result);
    }
}