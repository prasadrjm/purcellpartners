using System;
using System.Linq;

namespace MissingNumberFinderApp
{
    public class SumBasedMissingNumberFinder : IMissingNumberFinder
    {
        public int FindMissingNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Input array cannot be null or empty.");

            int n = numbers.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = numbers.Sum();

            return expectedSum - actualSum;
        }
    }
}
