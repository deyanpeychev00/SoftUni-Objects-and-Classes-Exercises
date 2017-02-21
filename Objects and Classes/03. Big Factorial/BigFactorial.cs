using System;
using System.Numerics;

namespace _03.Big_Factorial
{
   public class BigFactorial
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
