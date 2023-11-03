namespace Tests
{
    internal class FizzBuzzGenerator
    {
        public string Calculate(int userInput)
        {
            if(IsDivisibleBy3(userInput))
            {
                return "Fizz";
            }

            return userInput.ToString();
        }

        private bool IsDivisibleBy3(int userInput)
        {
            return userInput % 3 == 0;
        }
    }
}