using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
    public class BookLibrary
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var authorPrice = new Dictionary<string, double>();
            var bookList = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var currentBook = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = input[3],
                    ISBN = input[4],
                    Price = double.Parse(input[5])
                };
                bookList.Add(currentBook);
            }
            for (int i = 0; i < bookList.Count; i++)
            {
                if (!(authorPrice.ContainsKey(bookList[i].Author)))
                {
                    authorPrice[bookList[i].Author] = bookList[i].Price;
                }
                else
                    authorPrice[bookList[i].Author] += bookList[i].Price;
            }
            var output = authorPrice.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var element in output)
            {
                Console.WriteLine($"{element.Key} -> {element.Value:f2}");
            }

        }
    }
}
