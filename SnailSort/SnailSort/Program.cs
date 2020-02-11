using System;

namespace SnailSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array =
            {
                new[] {1, 2, 3, 1},
                new[] {4, 5, 6, 4},
                new[] {7, 8, 9, 7},
                new[] {7, 8, 9, 7}
            };

            var snail = SnailSolution.Snail(array);
            foreach (var val in snail)
            {
                Console.WriteLine(val);
            }
        }
    }
}