
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

        // Validate Scalene Triangle
        [TestMethod]
        public void ValidateScaleneTriangleFirst()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(7, 8, 9);

            // Assert
            Assert.AreEqual("Scalene Triangle", result);
        }
        [TestMethod]
        public void ValidateScaleneTriangleSecond()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(2, 3, 4);

            // Assert
            Assert.AreEqual("Scalene Triangle", result);
        }
        [TestMethod]
        public void ValidateScaleneTriangleThird()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(3, 4, 5);

            // Assert
            Assert.AreEqual("Scalene Triangle", result);
        }
        [TestMethod]
        public void ValidateScaleneTriangleFourth()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(4, 5, 6);

            // Assert
            Assert.AreEqual("Scalene Triangle", result);
        }
        [TestMethod]
        public void ValidateScaleneTriangleFifth()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(5, 6, 7);

            // Assert
            Assert.AreEqual("Scalene Triangle", result);
        }
        // Validate ZeroLengthSide Triangle
        [TestMethod]
        public void ValidateZeroLengthSideFirst()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(0, 1, 2);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        [TestMethod]
        public void ValidateZeroLengthSideSecond()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(2, 0, 3);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        [TestMethod]
        public void ValidateZeroLengthSideThird()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(4, 5, 0);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }
        [TestMethod]
        public void ValidateInvalidResponseFirst()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(3, 4, 9);

            // Assert
            Assert.AreEqual("Invalid Response", result);
        }

        [TestMethod]
        public void ValidateInvalidResponseSecond()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(2, 3, 8);

            // Assert
            Assert.AreEqual("Invalid Response", result);
        }

        [TestMethod]
        public void ValidateInvalidResponseThird()
        {
            // Arrange
            TriangleValidator validator = new TriangleValidator();

            // Act
            string result = validator.ValidateTriangle(1, 2, 5);

            // Assert
            Assert.AreEqual("Invalid Response", result);
        }
    }
}
