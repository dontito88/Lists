namespace SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            numbers.Sort();
            numbers.Reverse();

            foreach (var number in numbers)
            {
                if (Math.Sqrt(number) == (int) Math.Sqrt(number))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
