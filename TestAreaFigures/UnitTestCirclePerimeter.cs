using GeometryLibrary;

namespace TestAreaFigures
{
    [TestClass]
    public class UnitTestCirclePerimeter
    {
        [TestMethod]
        public void Test_1()
        {
            Circle circle = new Circle(2);
            double result = circle.Perimeter();
            Assert.AreEqual(12.566370614359172, result);
        }
        [TestMethod]
        public void Test_2()
        {
            Circle circle = new Circle(0);
            double result = circle.Perimeter();
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Test_3()
        {
            Circle circle = new Circle(2.5);
            double result = circle.Perimeter();
            Assert.AreEqual(15.707963267948966, result);
        }
        [TestMethod]
        public void Test_4()
        {
            Circle circle = new Circle(-2);
            double result = circle.Perimeter();
            Assert.AreEqual(12.566370614359172, result);
        }
    }
}