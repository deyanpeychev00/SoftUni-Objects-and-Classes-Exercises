using System;
using System.Globalization;

namespace _01.Day_of_Week
{
    public class DayOfWeek
    {
       public static void Main()
        {
            string input = Console.ReadLine();
            DateTime inputAsDate = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(inputAsDate.DayOfWeek);
        }
    }
}
