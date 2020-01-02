using System;

namespace CFundamentalsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Positive or Negative?");
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int num);
            Console.WriteLine($"The number {num} is {PositiveOrNegative(num)}");
        }

        public static string PositiveOrNegative(int num)
        {
              if (num > 0)
            {
                return "positive";
            }
              else if (num == 0)
            {
                return "neither positive nor negative";
            }
              else
            {
                return "negative";
            }
        }
    }
}
