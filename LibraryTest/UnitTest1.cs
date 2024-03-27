using NUnit.Framework;
using ShapeLibrary;
using NUnit.Framework;

namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class ShapeCalculatorTests
    {
        [Test]
        public void CalculateCircleArea_Test()
        {
            ShapeCalculator calculator = new ShapeCalculator();
            double result = calculator.CalculateCircleArea(5);
            Assert.That(result, Is.EqualTo(Math.PI * 25));
        }

        [Test]
        public void CalculateTriangleArea_Test()
        {
            ShapeCalculator calculator = new ShapeCalculator();
            double result = calculator.CalculateTriangleArea(3, 4, 5);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void IsRightTriangle_Test()
        {
            ShapeCalculator calculator = new ShapeCalculator();
            bool result = calculator.IsRightTriangle(3, 4, 5);
            Assert.IsTrue(result);
        }
    }
}