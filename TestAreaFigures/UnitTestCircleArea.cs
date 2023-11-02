using GeometryLibrary;

namespace TestAreaFigures
{
    [TestClass]
    public class UnitTestCircleArea
    {
        [TestMethod]
        public void Test_1()
        {
            Circle circle = new Circle(2);
            double result = circle.Area();
            Assert.AreEqual(12.566370614359172, result);
        }
        [TestMethod]
        public void Test_2()
        {
            Circle circle = new Circle(2.5);
            double result = circle.Area();
            Assert.AreEqual(19.634954084936208, result);
        }
        [TestMethod]
        public void Test_3()
        {
            Circle circle = new Circle();
            circle.R = 1;
            double result = circle.Area();
            Assert.AreEqual(3.141592653589793, result);
        }
    }
}