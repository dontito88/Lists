namespace RemoveNegativeAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativeAndReverse
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var newListOfNumbers = new List<int>();

            for (int i = listOfNumbers.Count - 1; i >= 0; i--)
            {
                if (listOfNumbers[i] > 0)
                {
                    newListOfNumbers.Add(listOfNumbers[i]);
                }
            }
            if (newListOfNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            Console.Write(string.Join(" ", newListOfNumbers));
        }
    }
}
