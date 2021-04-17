namespace ShadyNagy.FizzBuzz
{
    public class ValueEngine
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";
        private const string FIZZ_BUZZ = "FizzBuzz";

        public string Create(int input)
        {
            if (input == 0)
            {
                return input.ToString();
            }
            else if (input % 15 == 0)
            {
                return FIZZ_BUZZ;
            }else if (input % 3 == 0)
            {
                return FIZZ;
            }
            else if (input % 5 == 0)
            {
                return BUZZ;
            }
            else
            {
                return input.ToString();
            }
        }
    }
}
