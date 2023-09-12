namespace Tests
{
    public class Game
    {
        private int _score;

        public void Roll(int pins)
        {
            _score += pins;
        }

        public int Score()
        {
            return _score;
        }
    }
}