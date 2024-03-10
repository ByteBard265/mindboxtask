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
        if(radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Радиус должен быть больше 0");

        Radius = radius;
    }

    /// <summary>
    /// Радиус
    /// </summary>
    public double Radius { get; private set; }

    /// <summary>
    /// Возвращает площадь
    /// </summary>
    public override double Area() =>
        Math.Pow(Radius, 2) * Math.PI;
}
