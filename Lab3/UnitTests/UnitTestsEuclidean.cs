using Task1;

namespace UnitTests
{
    [TestClass]
    public class UnitTestsEuclidean
    {
        [TestMethod]
        public void TestMethodGetGCD()
        {
            Euclidean algorithm = new Euclidean();

            int res = algorithm.GetGCD(10, 20);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMethodGetGCD3()
        {
            Euclidean algorithm = new Euclidean();

            int res = algorithm.GetGCDMultiple(10, 20, 30);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMethodGetGCD4()
        {
            Euclidean algorithm = new Euclidean();

            int res = algorithm.GetGCDMultiple(10, 20, 30, 40);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMethodGetGCD5()
        {
            Euclidean algorithm = new Euclidean();

            int res = algorithm.GetGCDMultiple(10, 20, 30, 40, 50);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMethodGetGCDMultiple()
        {
            Euclidean algorithm = new Euclidean();

            int[] aaa = { 10, 20, 30, 40, 50 };
            int res = algorithm.GetGCDMultiple(values: aaa);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMethodGetBinaryGCD()
        {
            Euclidean algorithm = new Euclidean();

            int res = algorithm.GetBinaryGCD(10, 20);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMethodMeasureTimeGCD()
        {
            Euclidean algorithm = new Euclidean();

            TimeSpan ts = new TimeSpan();
            int res = algorithm.MeasureTimeGCD(1234, 568, out ts);
            Assert.AreEqual(2, res);
            Assert.AreNotEqual(TimeSpan.Zero, ts);
        }

        [TestMethod]
        public void TestMethodMeasureTimeBinaryGCD()
        {
            Euclidean algorithm = new Euclidean();

            TimeSpan ts = new TimeSpan();
            int res = algorithm.MeasureTimeBinaryGCD(1234, 568, out ts);
            Assert.AreEqual(2, res);
            Assert.AreNotEqual(TimeSpan.Zero, ts);
        }
    }
}