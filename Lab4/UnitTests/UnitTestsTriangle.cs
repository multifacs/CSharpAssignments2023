using Task1;

namespace UnitTests
{
    [TestClass]
    public class UnitTestsTriangle
    {
        [TestMethod]
        public void TestConstructor()
        {
            Triangle triangle = new Triangle(3, 4, 5);
        }

        [TestMethod]
        public void TestDoesExistTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(triangle.DoesExist(), true);
        }

        [TestMethod]
        public void TestDoesExistFalse()
        {
            Triangle triangle = new Triangle(1, 2, 3);
            Assert.AreEqual(triangle.DoesExist(), false);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(triangle.GetPerimeter(), 12);
        }

        [TestMethod]
        public void TestArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(triangle.GetArea(), 6);
        }
    }
}