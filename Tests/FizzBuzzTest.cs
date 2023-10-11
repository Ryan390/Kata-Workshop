using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    internal class FizzBuzzTest
    {
        private FizzBuzzGenerator _buzzGenerator;
        [SetUp]
        public void Setup()
        {
            _buzzGenerator = new FizzBuzzGenerator();
        }

        [Test]
        public void CanHandleAOne()
        {
            var result = _buzzGenerator.Calculate(1);
            Assert.AreEqual(1, result);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(4, 4)]
        [TestCase(7, 7)]
        [TestCase(8, 8)]
        public void CanHandleMultipleNumbers(int testInput, int expectedResult)
        {
            var result = _buzzGenerator.Calculate(testInput);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
