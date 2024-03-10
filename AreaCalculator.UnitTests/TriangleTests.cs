using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.UnitTests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Constructor_CorrectSides_Passes()
    {
        new Triangle(1, 2, 3);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Constructor_WrongFirstSide_Throws()
    {
        new Triangle(0, 2, 3);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Constructor_WrongSecondSide_Throws()
    {
        new Triangle(1, 0, 3);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Constructor_WrongThirdSide_Throws()
    {
        new Triangle(1, 2, 0);
    }

    [TestMethod]
    public void FirstSide_CorrectValue_ReturnCorrectValue()
    {
        // Arrange 
        var triangle = new Triangle(1, 2, 3);
        double expected = 1;

        // Act
        double actual = triangle.FirstSide;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SecondSide_CorrectValue_ReturnCorrectValue()
    {
        // Arrange 
        var triangle = new Triangle(1, 2, 3);
        double expected = 2;

        // Act
        double actual = triangle.SecondSide;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ThirdSide_CorrectValue_ReturnCorrectValue()
    {
        // Arrange 
        var triangle = new Triangle(1, 2, 3);
        double expected = 3;

        // Act
        double actual = triangle.ThirdSide;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Area_CorrectSides_ReturnCorrectResult()
    {
        // Arrange 
        var triangle = new Triangle(3, 4, 5);
        double expected = 6;

        // Act
        double actual = triangle.Area();

        // Assert
        Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void IsRectangular_RightTriangleFirstSideIsBiggest_ReturnTrue()
    {
        // Arrange 
        var triangle = new Triangle(5, 4, 3);

        // Act
        bool actual = triangle.IsRectangular();

        // Assert
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsRectangular_RightTriangleSecondSideIsBiggest_ReturnTrue()
    {
        // Arrange 
        var triangle = new Triangle(3, 5, 4);

        // Act
        bool actual = triangle.IsRectangular();

        // Assert
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsRectangular_RightTriangleThridSideIsBiggest_ReturnTrue()
    {
        // Arrange 
        var triangle = new Triangle(3, 4, 5);

        // Act
        bool actual = triangle.IsRectangular();

        // Assert
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsRectangular_NotRightTriangle_ReturnFalse()
    {
        // Arrange 
        var triangle = new Triangle(3, 4, 6);

        // Act
        bool actual = triangle.IsRectangular();

        // Assert
        Assert.IsFalse(actual);
    }
}
