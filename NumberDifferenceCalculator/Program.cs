using System;

namespace NumberDifferenceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen integer sayıları girin (örneğin: 56 45 68 77):");
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            int[] numbers = Array.ConvertAll(tokens, int.Parse);

            int smallDifferenceSum = CalculateSmallDifferenceSum(numbers);

            int largeSquareSum = CalculateLargeSquareSum(numbers);

            Console.WriteLine($"{smallDifferenceSum} {largeSquareSum}");

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static int CalculateSmallDifferenceSum(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number < 67)
                {
                    sum += 67 - number;
                }
            }
            return sum;
        }

        static int CalculateLargeSquareSum(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number > 67)
                {
                    int difference = number - 67;
                    sum += difference * difference;
                }
            }
            return sum;
        }
    }
}
