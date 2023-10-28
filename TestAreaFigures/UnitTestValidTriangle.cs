using GeometryLibrary;

namespace TestAreaFigures
{
    [TestClass]
    public class UnitTestValidTriangle
    {
        [TestMethod]
        public void TestTrue_1()
        {
            Triangle triangle = new Triangle();
            bool result = triangle.validTriangle(5, 12, 13);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestTrue_2()
        {
            Triangle triangle = new Triangle(5, 12, 13);
            bool result = triangle.validTriangle();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestFalse_1()
        {
            Triangle triangle = new Triangle();
            bool result = triangle.validTriangle(2, 3, 5);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestFalse_2()
        {
            Triangle triangle = new Triangle(2, 3, 5);
            bool result = triangle.validTriangle();
            Assert.IsFalse(result);
        }

    }
}