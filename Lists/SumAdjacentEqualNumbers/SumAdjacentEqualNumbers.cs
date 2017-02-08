namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == input[i + 1])
                {
                    sum += input[i] + input[i + 1];
                }
            }
            foreach (var item in input)
            {
                Console.WriteLine();
            }
        }
    }
}
