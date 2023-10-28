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
            Triangle triangle = new Triangle(-5, 12, 13);
            double result = triangle.Perimeter();
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Test_4()
        {
            Triangle triangle = new Triangle(5, -12, 13);
            double result = triangle.Perimeter();
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Test_5()
        {
            Triangle triangle = new Triangle(5, 12, -13);
            double result = triangle.Perimeter();
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Test_6()
        {
            Triangle triangle = new Triangle(-5, -12, -13);
            double result = triangle.Perimeter();
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Test_7()
        {
            Triangle triangle = new Triangle();
            double result = triangle.Perimeter();
            Assert.AreEqual(1.5, result);
        }
    }
}