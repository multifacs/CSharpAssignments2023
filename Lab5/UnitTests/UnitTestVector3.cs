using Task1;

namespace UnitTests
{
    [TestClass]
    public class UnitTestVector3
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            Vector3 vector = new();
            Assert.AreEqual(vector.X, 0);
            Assert.AreEqual(vector.Y, 0);
            Assert.AreEqual(vector.Z, 0);
        }
        [TestMethod]
        public void TestParamConstructor()
        {
            Vector3 vector = new(1, 2.5, 3);
            Assert.AreEqual(vector.X, 1);
            Assert.AreEqual(vector.Y, 2.5);
            Assert.AreEqual(vector.Z, 3);
        }
        [TestMethod]
        public void TestCopyConstructor()
        {
            Vector3 vectorA = new(1, 2.5, 3);
            Vector3 vectorB = new(vectorA);
            Assert.AreEqual(vectorA.X, vectorB.X);
            Assert.AreEqual(vectorA.Y, vectorB.Y);
            Assert.AreEqual(vectorA.Z, vectorB.Z);
        }
        [TestMethod]
        public void TestIndexer()
        {
            Vector3 vector = new(1, 2.5, 3);
            Assert.AreEqual(vector[0], 1);
            Assert.AreEqual(vector[1], 2.5);
            Assert.AreEqual(vector[2], 3);
        }
        [TestMethod]
        public void TestOpAdd()
        {
            Vector3 vectorA = new(1, 2.5, 3);
            Vector3 vectorB = new(4, 5, 6);
            Vector3 vectorC = vectorA + vectorB;
            Assert.AreEqual(vectorC.X, 5);
            Assert.AreEqual(vectorC.Y, 7.5);
            Assert.AreEqual(vectorC.Z, 9);
        }
        [TestMethod]
        public void TestOpSub()
        {
            Vector3 vectorA = new(1, 2.5, 3);
            Vector3 vectorB = new(4, 5, 6);
            Vector3 vectorC = vectorB - vectorA;
            Assert.AreEqual(vectorC.X, 3);
            Assert.AreEqual(vectorC.Y, 2.5);
            Assert.AreEqual(vectorC.Z, 3);
        }
        [TestMethod]
        public void TestOpMult()
        {
            Vector3 vectorA = new(1, 2.5, 3);
            Vector3 vectorB = new(4, 5, 6);
            double product = vectorA * vectorB;
            Assert.AreEqual(product, 34.5);
        }
        [TestMethod]
        public void TestToString()
        {
            Vector3 vector = new(1, 2.5, 3);
            Assert.AreEqual(vector.ToString(), "1, 2,5, 3");
        }
        [TestMethod]
        public void MultiplyByNum()
        {
            Vector3 vectorA = new(1, 2, 3);
            Vector3 vectorB = vectorA.MultiplyByNum(2.5);
            Assert.AreEqual(vectorB.X, 2.5);
            Assert.AreEqual(vectorB.Y, 5);
            Assert.AreEqual(vectorB.Z, 7.5);
        }
    }
}