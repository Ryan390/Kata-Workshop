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
            Assert.AreEqual("1", result);
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(7, "7")]
        [TestCase(8, "8")]
        public void CanHandleMultipleNumbers(int testInput, string expectedResult)
        {
            var result = _buzzGenerator.Calculate(testInput);
            Assert.AreEqual(expectedResult, result);
        }


        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        public void CanHandleFizzNumbers(int testInput, string expectedResult)
        {
            var result = _buzzGenerator.Calculate(testInput);
            Assert.AreEqual(expectedResult, result);
        }


        [TestCase(35, "Buzz")]
        [TestCase(10, "Buzz")]
        public void CanHandleBuzzNumbers(int testInput, string expectedResult)
        {
            var result = _buzzGenerator.Calculate(testInput);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void CanHandleFizzBuzzNumbers(int testInput, string expectedResult)
        {
            var result = _buzzGenerator.Calculate(testInput);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
