using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    public class AdvertisementMessage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var phrases = new string[]
            {
                "Excellent product.",
                "Such a great Product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };
            var events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but how I feel awesome.",
                "Try it yourself, I am very satisfied",
                "I feel great!"
            };
            var authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            var cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var randomPhrase = new Random();
            var randomEvent = new Random();
            var randomAuthor = new Random();
            var randomCity = new Random();

            for (int i = 0; i < n; i++)
            {
                var currentRandomPhrase = randomPhrase.Next(0, phrases.Length);
                var currentRandomEvent = randomEvent.Next(0, events.Length);
                var currentRandomAuthor = randomAuthor.Next(0, authors.Length);
                var currentRandomCity = randomCity.Next(0, cities.Length);

                Console.WriteLine($"{phrases[currentRandomPhrase]} {events[currentRandomEvent]} {authors[currentRandomAuthor]} - {cities[currentRandomCity]}");
            }
        }
    }
}
