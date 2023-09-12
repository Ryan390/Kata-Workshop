using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GameTests
    {
        private Game _game;

        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        [Test]
        public void RollingAOne()
        {
            _game.Roll(1);
            Assert.AreEqual(1, _game.Score());
        }

        [Test]
        public void RollingAThree()
        {
            _game.Roll(3);
            Assert.AreEqual(3, _game.Score());
        }

        //[Test]
        //public void RollingASpare()
        //{
        //    _game.Roll(1);
        //    _game.Roll(9);
        //    _game.Roll(2);
        //    Assert.AreEqual(14, _game.Score());
        //}
    }
}
