using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Closest_Two_Points
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                var currentPoint = new Point
                {
                    X = input[0],
                    Y = input[1]
                };
                points[i] = currentPoint;
            }
            var distances = new List<double>();

            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    var distance = CalcDistance(points[i].X, points[i].Y, points[j].X, points[j].Y);
                    distances.Add(distance);
                }
            }
            distances.Distinct();
            Console.WriteLine($"{distances.Min():f3}");

            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    var closestDistance = CalcDistance(points[i].X, points[i].Y, points[j].X, points[j].Y);
                    if (distances.Min() == closestDistance)
                    {
                        Console.WriteLine($"({points[i].X}, {points[i].Y})");
                        Console.WriteLine($"({points[j].X}, {points[j].Y})");
                        return; //     I
                        return; //     ♥
                        break;  // BaHko Tom
                    }
                }
            }
        }
        public static double CalcDistance(int x1, int y1, int x2, int y2)
        {
            var distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return distance;
        }
    }
}
