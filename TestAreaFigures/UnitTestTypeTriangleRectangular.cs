using GeometryLibrary;

namespace TestAreaFigures
{
    [TestClass]
    public class UnitTestTypeTriangleRectangular
    {
        [TestMethod]
        public void Test_1()
        {
            Triangle triangle = new Triangle();
            string result = triangle.typeTriangleAtTheCorners(5, 12, 13);
            Assert.AreEqual("Треугольник прямоугольный", result);
        }
        [TestMethod]
        public void Test_2()
        {
            Triangle triangle = new Triangle(5, 12, 13);
            string result = triangle.typeTriangleAtTheCorners();
            Assert.AreEqual("Треугольник прямоугольный", result);
        }

    }
}