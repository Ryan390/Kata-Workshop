using NUnit.Framework;

namespace Tests
{

    internal class FizzBuzzTest
    {
        private FizzBuzzGenerator _buzzGenerator;
        [SetUp]
        public void Setup()
        {
            _buzzGenerator = new FizzBuzzGenerator();
        }

        [Test]
        public void CanFizzBuzz()
        {
            _buzzGenerator = new FizzBuzzGenerator();
            _buzzGenerator.Calculate();
        }
    }
}
