using System;
using System.Linq;

namespace MissingNumberFinderApp
{
    public class ConsoleInputProvider : IInputProvider
    {
        public int[] ReadNumbers()
        {
            Console.WriteLine("Enter numbers separated by commas (e.g., 3,0,1):");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Input cannot be empty.");

            return input
                .Split(',')
                .Select(str => int.Parse(str.Trim()))
                .ToArray();
        }
    }
}
