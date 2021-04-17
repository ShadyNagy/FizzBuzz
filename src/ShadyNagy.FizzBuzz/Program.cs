using System;

namespace ShadyNagy.FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var valueEngine = new ValueEngine();

            for (var value = 1; value <= 100; value++)
            {
                Console.WriteLine(valueEngine.Create(value));
            }

            Console.ReadKey();
        }
    }
}
