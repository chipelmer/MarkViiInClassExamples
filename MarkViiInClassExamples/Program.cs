using System;
using System.Collections.Generic;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guesses = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a guess:");
                string guess = Console.ReadLine();

                if (guesses.Contains(guess))
                {
                    continue;
                }
                else
                {
                    guesses.Add(guess);
                }

                Console.WriteLine("That's a new guess!");
            }

            Console.WriteLine("You guessed:");
            foreach (string guess in guesses)
            {
                Console.WriteLine(guess);
            }
        }

        static bool ContainsAtLeastTwoEvenNumbers(List<int> numbers)
        {
            int countOfEvens = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    countOfEvens += 1;
                }

                if (countOfEvens >= 2)
                {
                    return true;
                }
            }

            return false;
        }

        static bool ContainsAnEight(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number == 8)
                {
                    return true;
                }
            }

            return false;
        }

        static int SumArray(int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total = total + number;
            }

            return total;
        }
    }
}
