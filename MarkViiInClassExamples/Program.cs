using System;
using System.Collections.Generic;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] { 99, 100, 101 },
                new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
                new int[] { 7 },
                new int[] { 8, 8, 8, 8, 8 },
                new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            };

            int a = jaggedArray[0][1]; // 100
            int b = jaggedArray[2][1]; // index out of bounds
            int c = jaggedArray[1][0]; // 3
            int[] d = jaggedArray[4]; // gets an array, not a single int



            int[,] multidimensionalArray = new int[,]
            {
                { 3, 4, 3 },
                { 7, 7, 7 },
                { 9, 8, 9 },
                { 1, 1, 1 },
                { 4, 3, 2 }
            };

            int[][] jaggedSameAsMultiArray = new int[][]
            {
                new int[] { 3, 4, 4 },
                new int[] { 7, 7, 7 },
                new int[] { 9, 8, 9 },
                new int[] { 1, 1, 1 },
                new int[] { 4, 3, 2 }
            };
        }
    }
}
