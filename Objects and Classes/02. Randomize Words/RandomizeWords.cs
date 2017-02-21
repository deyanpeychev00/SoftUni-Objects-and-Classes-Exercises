using System;

namespace _02.Randomize_Words
{
    public class RandomizeWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var randomNumber = new Random();

            for (int i = 0; i < input.Length - 1; i++)
            {
                var currentWord = input[i];
                var currentRandom = randomNumber.Next(0, input.Length - 1);

                input[i] = input[currentRandom];
                input[currentRandom] = currentWord;
            }
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }

        }
    }
}
