namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq; 

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            string[] inputNumbers = Console.ReadLine().Split();
            int[] parsedNumbers = new int[inputNumbers.Length];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                parsedNumbers[i] = int.Parse(inputNumbers[i]);
            }

            List<int> longestSubsequence = new List<int>();
            List<int> currentSubsequence = new List<int>();

            currentSubsequence.Add(parsedNumbers[0]);

            for (int i = 1; i < parsedNumbers.Length; i++)
            {
                if (parsedNumbers[i] == currentSubsequence[0])
                {
                    currentSubsequence.Add(parsedNumbers[i]);
                }
                else
                {
                    if (currentSubsequence.Count > longestSubsequence.Count)
                    {
                        longestSubsequence = new List<int>();
                        for (int j = 0; j < currentSubsequence.Count; j++)
                        {
                            longestSubsequence.Add(currentSubsequence[j]);
                        }
                    }
                    currentSubsequence = new List<int>();
                    currentSubsequence.Add(parsedNumbers[i]);
                }
            }
            if (currentSubsequence.Count > longestSubsequence.Count)
            {
                longestSubsequence = new List<int>();
                for (int j = 0; j < currentSubsequence.Count; j++)
                {
                    longestSubsequence.Add(currentSubsequence[j]);
                }
            }
            Console.WriteLine(string.Join(" ", longestSubsequence));
        }
    }
}
