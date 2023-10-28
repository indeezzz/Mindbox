using GeometryLibrary;

namespace TestAreaFigures
{
    [TestClass]
    public class UnitTestTypeTriangleObtuseAngle
    {
        [TestMethod]
        public void Test_1()
        {
            Triangle triangle = new Triangle();
            string result = triangle.typeTriangleAtTheCorners(6, 5, 9);
            Assert.AreEqual("Треугольник тупоугольный", result);
        }
        [TestMethod]
        public void Test_2()
        {
            Triangle triangle = new Triangle(6, 5, 9);
            string result = triangle.typeTriangleAtTheCorners();
            Assert.AreEqual("Треугольник тупоугольный", result);
        }

    }
}