namespace SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            string[] inputNumbers = Console.ReadLine().Split();
            int sum = 0;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                string currentNumber = inputNumbers[i];
                string reversedNumber = string.Join("", currentNumber.Reverse());

                int parsedNumber = int.Parse(reversedNumber);
                sum += parsedNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
