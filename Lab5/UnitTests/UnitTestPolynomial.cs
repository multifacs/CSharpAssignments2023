using Task2;

namespace UnitTests
{
    [TestClass]
    public class UnitTestPolynomial
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            Polynomial polynomial = new();
            Assert.AreEqual(polynomial.A, 0);
            Assert.AreEqual(polynomial.B, 0);
        }
        [TestMethod]
        public void TestParamConstructor()
        {
            Polynomial polynomial = new(1, 2);
            Assert.AreEqual(polynomial.A, 1);
            Assert.AreEqual(polynomial.B, 2);
        }
        [TestMethod]
        public void TestCopyConstructor()
        {
            Polynomial polynomialA = new(1, 2);
            Polynomial polynomialB = new(polynomialA);
            Assert.AreEqual(polynomialA.A, polynomialB.A);
            Assert.AreEqual(polynomialB.B, polynomialB.B);
        }
        [TestMethod]
        public void TestSetters()
        {
            Polynomial polynomial = new(1, 2);
            polynomial.A = 3;
            polynomial.B = 4;
            Assert.AreEqual(polynomial.A, 3);
            Assert.AreEqual(polynomial.B, 4);
        }
        [TestMethod]
        public void TestOpAdd()
        {
            Polynomial polynomialA = new(1, 2);
            Polynomial polynomialB = new(3, 4);
            Polynomial polynomialC = polynomialA + polynomialB;
            Assert.AreEqual(polynomialC.A, 4);
            Assert.AreEqual(polynomialC.B, 6);
        }
        [TestMethod]
        public void TestOpSub()
        {
            Polynomial polynomialA = new(1, 2);
            Polynomial polynomialB = new(3, 4);
            Polynomial polynomialC = polynomialB - polynomialA;
            Assert.AreEqual(polynomialC.A, 2);
            Assert.AreEqual(polynomialC.B, 2);
        }
        [TestMethod]
        public void TestCalc()
        {
            Polynomial polynomial = new(2, 3);
            Assert.AreEqual(polynomial.Calc(4), 11);
        }
        [TestMethod]
        public void TestToString()
        {
            Polynomial polynomial = new(1, 2);
            Assert.AreEqual(polynomial.ToString(), "1 * x + 2");
        }
    }
}