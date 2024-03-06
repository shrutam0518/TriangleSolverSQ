
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
    }
}
