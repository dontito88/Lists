namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq; 

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                var counter = 0;
                if (input[i] == input[i + 1])
                {
                    counter++;
                }
                Console.WriteLine(counter);
            }
        }
    }
}
