namespace Tests
{
    internal class FizzBuzzGenerator
    {
        public string Calculate(int userInput)
        {
            if (IsDivisibleBy3And5(userInput))
            {
                return "FizzBuzz";
            }
            if (IsDivisibleBy3(userInput))
            {
                return "Fizz";
            }

            if(IsDivisibleBy5(userInput))
            {
                return "Buzz";
            }

            return userInput.ToString();
        }

        private bool IsDivisibleBy3And5(int userInput)
        {
            return userInput % 5 == 0 && userInput % 3 == 0;
        }

        private bool IsDivisibleBy5(int userInput)
        {
            return userInput % 5 == 0;
        }

        private bool IsDivisibleBy3(int userInput)
        {
            return userInput % 3 == 0;
        }
    }
}