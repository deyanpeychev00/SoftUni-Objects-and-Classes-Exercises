using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Intersection_of_Circles
{
    public class IntersectionOfCircles
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var firstCircle = new Circle
            {
                Radius = input[2],
                Center = new Point
                {
                    X = input[0],
                    Y = input[1]
                }
            };

            input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondCircle = new Circle
            {
                Radius = input[2],
                Center = new Point
                {
                    X = input[0],
                    Y = input[1]
                }
            };

            var isIntersect = IsIntersect(firstCircle.Radius, firstCircle.Center.X, firstCircle.Center.Y, secondCircle.Radius, secondCircle.Center.X, secondCircle.Center.Y);
            if (isIntersect)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
        public static bool IsIntersect(int firstCircleRadius, int firstCircleX, int firstCircleY, int secondCircleRadius, int secondCircleX, int secondCircleY)
        {
            var distance = CalcDistance(firstCircleX, firstCircleY, secondCircleX, secondCircleY);
            if (distance <= firstCircleRadius + secondCircleRadius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double CalcDistance(int x1, int y1, int x2, int y2)
        {
            var distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return distance;
        }
    }
}
