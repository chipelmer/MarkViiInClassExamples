using System;
using System.Linq;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 7, 8, 9, 2, 34, 5 };

            // Add5() is an extension method that we wrote
            int numberPlus5 = 3.Add5();

            // Sum() is an extension method from Linq
            int sumOfNumbers = numbers.Sum();
        }
    }

    static class ExtensionMethods
    {
        public static int Add5(this int number)
        {
            return number + 5;
        }
    }
}
