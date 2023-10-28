using GeometryLibrary;

namespace TestAreaFigures
{
    [TestClass]
    public class UnitTestTypeTriangleIsosceles
    {
        [TestMethod]
        public void Test_1()
        {
            Triangle triangle = new Triangle();
            string result = triangle.typeTriangleOnThSides(9, 9, 8);
            Assert.AreEqual("Треугольник равнобедренный", result);
        }
        [TestMethod]
        public void Test_2()
        {
            Triangle triangle = new Triangle(9, 9, 8);
            string result = triangle.typeTriangleOnThSides();
            Assert.AreEqual("Треугольник равнобедренный", result);
        }

    }
}