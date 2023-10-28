using GeometryLibrary;

namespace TestAreaFigures
{
    [TestClass]
    public class UnitTestTypeTriangleVersatile
    {
        [TestMethod]
        public void Test_1()
        {
            Triangle triangle = new Triangle();
            string result = triangle.typeTriangleOnThSides(3, 6, 5);
            Assert.AreEqual("Треугольник разносторонний", result);
        }
        [TestMethod]
        public void Test_2()
        {
            Triangle triangle = new Triangle(3, 6, 5);
            string result = triangle.typeTriangleOnThSides();
            Assert.AreEqual("Треугольник разносторонний", result);
        }

    }
}