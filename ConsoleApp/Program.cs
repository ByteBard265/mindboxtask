using AreaCalculator;

Circle figure = new Circle(1);

Console.WriteLine(figure.Area());

Triangle triangle = new Triangle(3, 4, 5);

Console.WriteLine(triangle.Area());
Console.WriteLine(triangle.IsRectangular());

var list1 = new List<Figure>() { new Circle(5), new Circle(3), new Triangle(3, 4, 5) };

foreach (Figure f in list1)
    Console.WriteLine(f.Area());