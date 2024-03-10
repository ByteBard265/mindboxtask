namespace AreaCalculator;

/// <summary>
/// Круг
/// </summary>
public class Circle : Figure
{
    /// <summary>
    /// Конструктор круга
    /// </summary>
    /// <param name="radius">радиус</param>
    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// Радиус
    /// </summary>
    public double Radius { get; set; }

    /// <summary>
    /// Воозвращает площадь
    /// </summary>
    public override double Area() =>
        Math.Pow(Radius, 2) * Math.PI;
}
