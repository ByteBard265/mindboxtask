namespace AreaCalculator;

/// <summary>
/// Треугольник
/// </summary>
public class Triangle : Figure
{
    /// <summary>
    /// Конструктор треугольника
    /// </summary>
    /// <param name="firstSide">Первая сторона</param>
    /// <param name="secondSide">Вторая сторона</param>
    /// <param name="thirdSide">Третья сторона</param>
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0)
            throw new ArgumentOutOfRangeException(nameof(firstSide), "Первая сторона должна быть больше 0");

        if (secondSide <= 0)
            throw new ArgumentOutOfRangeException(nameof(secondSide), "Вторая сторона должна быть больше 0");

        if (thirdSide <= 0)
            throw new ArgumentOutOfRangeException(nameof(secondSide), "Третья сторона должна быть больше 0");

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    /// <summary>
    /// Первая сторона
    /// </summary>
    public double FirstSide { get; private set; }

    /// <summary>
    /// Вторая сторона
    /// </summary>
    public double SecondSide { get; private set; }

    /// <summary>
    /// Третья сторона
    /// </summary>
    public double ThirdSide { get; private set; }

    /// <summary>
    /// Возвращает площадь треугольника
    /// </summary>
    public override double Area()
    {
        double perimeter = Perimeter()/2;
        return Math.Sqrt(perimeter*(perimeter-FirstSide)*(perimeter-SecondSide)*(perimeter-ThirdSide));
    }

    /// <summary>
    /// Определяет прямоугольный ли треугольник?
    /// </summary>
    /// <returns>true - если прямоугольный, иначе false</returns>
    public bool IsRectangular()
    {
        var sides = new List<double>() { FirstSide, SecondSide, ThirdSide };
        sides = sides.Order().ToList();
        return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    /// <summary>
    /// Возвращает периметр треугольника
    /// </summary>
    /// <returns></returns>
    private double Perimeter() =>
        FirstSide + SecondSide + ThirdSide;
}
