using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.Book_Library_Modification
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
    public class BookLibraryModification
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var TitlesByDate = new Dictionary<string, DateTime>();
            var bookList = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var currentBook = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = input[4],
                    Price = double.Parse(input[5])
                };
                bookList.Add(currentBook);
            }
            var dateToCompare = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].ReleaseDate > dateToCompare)
                {
                    TitlesByDate[bookList[i].Title] = bookList[i].ReleaseDate;
                }
            }
            var output = TitlesByDate.OrderBy(x => x.Value).ThenBy(x => x.Key);
            foreach (var element in output)
            {
                Console.WriteLine($"{element.Key} -> {element.Value.ToString("dd.MM.yyyy")}");
            }

        }
    }
}
