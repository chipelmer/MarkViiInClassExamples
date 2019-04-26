using System;
using System.Collections.Generic;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "abc"; // should result in "A-Bb-Ccc"
            string test2 = "xYzM"; // should result in "X-Yy-Zzz-Mmmm"
            Console.WriteLine(Accum(test1));
            Console.WriteLine(Accum(test2));
        }

        public static string Accum(string s)
        {
            string result = "";

            // Each letter needs to be used. We'll access using this variable `index`.
            for (int index = 0; index < s.Length; index++)
            {
                // Each letter needs to be repeated. We'll use `repeatCount` to control how many times.
                // The number of repetitions is the position of the letter, which is 1 greater than its index, so `index + 1`.
                for (int repeatCount = 1; repeatCount <= index + 1; repeatCount++)
                {
                    // If it's the first time for a letter, it should be uppercase.
                    if (repeatCount == 1)
                    {
                        // If it's not the very first letter, it should have a hyphen before it.
                        if (index > 0)
                        {
                            result += "-";
                        }

                        result += char.ToUpper(s[index]);
                    }
                    else // If it's not the first time for a letter, it should be lowercase.
                    {
                        result += char.ToLower(s[index]);
                    }
                }
            }

            return result;
        }
    }
}
