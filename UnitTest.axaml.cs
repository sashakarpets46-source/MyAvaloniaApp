using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MyAvaloniaApp;

public partial class UnitTest : Window
{
    public UnitTest()
    {
        InitializeComponent();
    }

    private void CalculateTask1(object? sender, RoutedEventArgs e)
    {
        int a = int.Parse(TextA1.Text!);
        int b = int.Parse(TextB1.Text!);
        int c = int.Parse(TextC1.Text!);

        Calculation_abc calculation = new Calculation_abc(a, b, c);

        double result = calculation.D();

        Result1.Text = $"Результат: {result}";
    }

    private void CalculateTask2(object? sender, RoutedEventArgs e)
    {
        int a = int.Parse(TextA2.Text!);
        int b = int.Parse(TextB2.Text!);

        Calculation_ab calculation = new Calculation_ab(a, b);

        long result = calculation.Product();

        Result2.Text = $"Результат: {result}";
    }

    private void CalculateTask3(object? sender, RoutedEventArgs e)
    {
        double a = double.Parse(TextA3.Text!);
        double h = double.Parse(TextH3.Text!);

        HexagonalPrism prism = new HexagonalPrism(a, h);

        double volume = prism.Volume();
        double lateralArea = prism.LateralSurfaceArea();
        double totalArea = prism.TotalSurfaceArea();

        Result3.Text =
            $"Об'єм: {volume:F2}\n" +
            $"Бічна площа: {lateralArea:F2}\n" +
            $"Повна площа: {totalArea:F2}";
    }
}