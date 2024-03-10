using AreaCalculator;

namespace AreaCalculator.UnitTests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void Area_CorrectRadius_ReturnCorrectValue()
    {
        // Arrange
        var circle = new Circle(1);
        double expected = 3.14159;

        // Act
        double actual = Math.Round(circle.Area(), 5);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Radius_CorrectRadius_ReturnCorrectValue()
    {
        // Arrange 
        var circle = new Circle(1);
        double expected = 1;

        // Act
        double actual = circle.Radius;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Constructor_CorrectRadius_Passes()
    {
        new Circle(1);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Constructor_ReceiveWrongRadius_Throws()
    {
        new Circle(0);
    }
}
