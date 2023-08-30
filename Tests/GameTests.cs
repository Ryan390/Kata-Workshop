using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void canRoll()
        {
            var newGame = new Game();
            newGame.Roll();
            Assert.Pass();
        }
    }

    public class Game
    {
        public void Roll()
        {
            
        }
    }
}
