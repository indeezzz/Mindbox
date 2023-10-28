using GeometryLibrary;

namespace TestAreaFigures
{
    [TestClass]
    public class UnitTestTriangleArea
    {
        [TestMethod]
        public void Test_1()
        {
            Triangle triangle = new Triangle(5, 12, 13);
            double result = triangle.Area();
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Test_2()
        {
            Triangle triangle = new Triangle(6, 5, 9);
            double result = triangle.Area();
            Assert.AreEqual(14.142135623730951, result);
        }
        [TestMethod]
        public void Test_3()
        {
            Triangle triangle = new Triangle(-5, 12, 13);
            double result = triangle.Area();
            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void Test_4()
        {
            Triangle triangle = new Triangle(5, -12, 13);
            double result = triangle.Area();
            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void Test_5()
        {
            Triangle triangle = new Triangle(5, 12, -13);
            double result = triangle.Area();
            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void Test_6()
        {
            Triangle triangle = new Triangle(-5, -12, -13);
            double result = triangle.Area();
            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void Test_7()
        {
            Triangle triangle = new Triangle();
            double result = triangle.Area();
            Assert.AreEqual(0.4330127018922193, result);
        }
    }
}