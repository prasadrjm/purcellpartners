using System;

namespace MissingNumberFinderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputProvider inputProvider = new ConsoleInputProvider();
            IMissingNumberFinder missingNumberFinder = new SumBasedMissingNumberFinder();

            try
            {
                int[] numbers = inputProvider.ReadNumbers();
                int missingNumber = missingNumberFinder.FindMissingNumber(numbers);

                Console.WriteLine($"The missing number is: {missingNumber}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
