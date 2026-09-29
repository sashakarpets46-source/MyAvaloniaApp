using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAvaloniaApp;

namespace MyAvaloniaApp.Task3.Tests;

[TestClass]
public class HexagonalPrismTest
{
    [TestMethod]
    public void HexagonalPrism_Volume()
    {
        HexagonalPrism prism = new HexagonalPrism(2, 5);

        double result = prism.Volume();

        Assert.AreEqual(30 * Math.Sqrt(3), result, 0.0001);
    }

    [TestMethod]
    public void HexagonalPrism_LateralSurfaceArea()
    {
        HexagonalPrism prism = new HexagonalPrism(2, 5);

        double result = prism.LateralSurfaceArea();

        Assert.AreEqual(60, result);
    }

    [TestMethod]
    public void HexagonalPrism_TotalSurfaceArea()
    {
        HexagonalPrism prism = new HexagonalPrism(2, 5);

        double result = prism.TotalSurfaceArea();

        Assert.AreEqual(60 + 12 * Math.Sqrt(3), result, 0.0001);
    }
}