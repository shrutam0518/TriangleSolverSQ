
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleSolver;

namespace TriangleSolverSQ
{
    [TestClass]
    public class TriangleValidatorTests
    {
        // Validate Equilateral Triangle
        [TestMethod]
        public void ValidateEquilateralTriangle()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(9, 9, 9);

            // Assert
            Assert.AreEqual("Equilateral Triangle", result);
        }

        // Validate Isosceles Triangle
        [TestMethod]
        public void ValidateIsoscelesTriangleFirst()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(9, 9, 1);

            // Assert
            Assert.AreEqual("Isosceles Triangle", result);
        }
        [TestMethod]
        public void ValidateIsoscelesTriangleSecond()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(9, 1, 9);

            // Assert
            Assert.AreEqual("Isosceles Triangle", result);
        }

        [TestMethod]
        public void ValidateIsoscelesTriangleThird()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(1, 9, 9);

            // Assert
            Assert.AreEqual("Isosceles Triangle", result);
        }
    }
}
