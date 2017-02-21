using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    public class SalesReport
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var salesByTown = new SortedDictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var currentSale = new Sale
                {
                    Town = input[0],
                    Product = input[1],
                    Price = double.Parse(input[2]),
                    Quantity = double.Parse(input[3])
                };
                if (!salesByTown.ContainsKey(currentSale.Town))
                {
                    salesByTown.Add(currentSale.Town, currentSale.Price * currentSale.Quantity);
                }
                else
                {
                    salesByTown[currentSale.Town] += currentSale.Price * currentSale.Quantity;
                }
            }
            foreach (var sale in salesByTown)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:f2}");
            }
        }
    }
}
