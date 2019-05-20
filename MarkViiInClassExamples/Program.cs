using System;
using System.Collections.Generic;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Factorial(5);
            Console.WriteLine(answer);
        }

        static int Factorial(int n)
        {
            Console.WriteLine($"Calculating {n}!");
            if (n == 0)
            {
                Console.WriteLine("0! is 1, so returning 1 to caller");
                return 1;
            }
            else
            {
                Console.WriteLine($"Multiplying {n} times {n - 1}! (n-1)");
                int result = n * Factorial(n - 1);
                Console.WriteLine($"{n}! was {result}, returning {result} to caller");
                return result;
            }
        }
    }
}
