using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class FizzBuzzTest
    {
        [Test]
        public void CanFizzBuzz()
        {
            var Foo = new FizzBuzzGenerator();
            Foo.Calculate();
            Assert.Pass();
        }
    }

    internal class FizzBuzzGenerator
    {
        public void Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
