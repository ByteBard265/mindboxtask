using System.Reflection.Metadata.Ecma335;

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
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    /// <summary>
    /// Первая сторона
    /// </summary>
    public double FirstSide { get; set; }

    /// <summary>
    /// Вторая сторона
    /// </summary>
    public double SecondSide { get; set; }

    /// <summary>
    /// Третья сторона
    /// </summary>
    public double ThirdSide { get; set; }

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
        sides.Order();
        return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    /// <summary>
    /// Возвращает периметр треугольника
    /// </summary>
    /// <returns></returns>
    private double Perimeter() =>
        FirstSide + SecondSide + ThirdSide;
}
