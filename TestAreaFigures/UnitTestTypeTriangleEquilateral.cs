using GeometryLibrary;
using System.Text;

namespace TestAreaFigures
{
    [TestClass]
    public class UnitTestTypeTriangleEquilateral
    {
        [TestMethod]
        public void Test_1()
        {
            Triangle triangle = new Triangle();
            string result = triangle.typeTriangleOnThSides(8, 8, 8);
            Assert.AreEqual($"Треугольник равносторонний", result);
        }
        [TestMethod]
        public void Test_2()
        {
            Triangle triangle = new Triangle(8, 8, 8);
            string result = triangle.typeTriangleOnThSides();
            Assert.AreEqual($"Треугольник равносторонний", result);
        }

    }
}