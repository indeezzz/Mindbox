using GeometryLibrary;

namespace TestAreaFigures
{
    [TestClass]
    public class UnitTestTypeTriangleSharpAngled
    {
        [TestMethod]
        public void Test_1()
        {
            Triangle triangle = new Triangle();
            string result = triangle.typeTriangleAtTheCorners(5, 6, 7);
            Assert.AreEqual("Треугольник остроугольный", result);
        }
        [TestMethod]
        public void Test_2()
        {
            Triangle triangle = new Triangle(5, 6, 7);
            string result = triangle.typeTriangleAtTheCorners();
            Assert.AreEqual("Треугольник остроугольный", result);
        }

    }
}