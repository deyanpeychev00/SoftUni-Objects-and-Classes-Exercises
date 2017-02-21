using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Count_Working_Days
{
    public class CountWorkingDays
    {
        public static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime[] officialHolidays = new DateTime[]
            {
                new DateTime(4, 01, 01),
                new DateTime(4, 03, 03),
                new DateTime(4, 05, 01),
                new DateTime(4, 05, 06),
                new DateTime(4, 05, 24),
                new DateTime(4, 09, 06),
                new DateTime(4, 09, 22),
                new DateTime(4, 11, 01),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26),
            };
            var workingDays = 0;

            for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                var tempDate = new DateTime(4, currentDate.Month, currentDate.Day);

                if (!officialHolidays.Contains(tempDate) && currentDate.DayOfWeek != DayOfWeek.Sunday && currentDate.DayOfWeek != DayOfWeek.Saturday)
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);

        }
    }
}
