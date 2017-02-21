using System;
using System.Linq;


namespace _04.Distance_Between_Points
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var point1 = new Point
            {
                X = input[0],
                Y = input[1]
            };

            input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var point2 = new Point
            {
                X = input[0],
                Y = input[1]
            };

            var distance = CalcDistance(point1.X, point1.Y, point2.X, point2.Y);

            Console.WriteLine($"{distance:f3}");
        }
        public static double CalcDistance(int x1, int y1, int x2, int y2)
        {
            var distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return distance;
        }

    }
}
