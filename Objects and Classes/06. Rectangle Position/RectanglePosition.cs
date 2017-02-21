using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    public class RectanglePosition
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var first = new Rectangle
            {
                X1 = input[0], // Left
                Y1 = input[1], // Top
                Width = input[2],
                Height = input[3]
            };
            first.X2 = first.X1 + first.Width; // Right
            first.Y2 = first.Y1 + first.Height; // Bottom
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var second = new Rectangle
            {
                X1 = input[0], // Left
                Y1 = input[1], // Top
                Width = input[2],
                Height = input[3]
            };
            second.X2 = second.X1 + second.Width; // Right
            second.Y2 = second.Y1 + second.Height; // Bottom

            var isInside = IsInside(first.X1, second.X1, first.Y1, second.Y1, first.X2, second.X2, first.Y2, second.Y2 );
            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
                Console.WriteLine("Not inside");
        }
        public static bool IsInside(int firstX1, int secondX1, int firstY1, int secondY1, int firstX2, int secondX2, int firstY2, int secondY2)
        {
            if ((firstX1 >= secondX1) 
                && (firstX2 <= secondX2)
                && (firstY1 <=secondY1)
                && (firstY2 <= secondY2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
