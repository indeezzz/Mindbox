using GeometryLibrary;

namespace TestAreaFigures
{
    [TestClass]
    public class UnitTestTrianglePerimeter
    {
        [TestMethod]
        public void Test_1()
        {
            Triangle triangle = new Triangle(5, 12, 13);
            double result = triangle.Perimeter();
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Test_2()
        {
            Triangle triangle = new Triangle(6, 5, 9);
            double result = triangle.Perimeter();
            Assert.AreEqual(10, result);
        }      
        [TestMethod]
        public void Test_3()
        {
            Triangle triangle = new Triangle();
            triangle.A = 1;
            triangle.B = 1;
            triangle.C = 1;
            if (triangle.validTriangle(triangle.A, triangle.B, triangle.C))
            {
                double result = triangle.Perimeter();
                Assert.AreEqual(1.5, result);
            }

        }
    }
}