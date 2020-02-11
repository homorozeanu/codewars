using System.Collections.Generic;
using System.Linq;

namespace SnailSort
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            if (array[0].Length == 0) return new int[] { };

            List<int> resultList = new List<int>();
            SnailRec(ref resultList, array, 0, 0, array.Length - 1, array.Length - 1);
            return resultList.ToArray();
        }

        private static void SnailRec(ref List<int> result, int[][] array, int lRow, int lCol, int rRow, int rCol)
        {
            if (lRow < rRow)
            {
                for (int i = lRow; i <= rCol; i++)
                {
                    result.Add(array[lRow][i]);
                }

                for (int j = lRow + 1; j <= rRow; j++)
                {
                    result.Add(array[j][rRow]);
                }

                for (int k = rRow - 1; k >= lCol; k--)
                {
                    result.Add(array[rRow][k]);
                }

                for (int l = rRow - 1; l > lRow; l--)
                {
                    result.Add(array[l][lCol]);
                }

                SnailRec(ref result, array, lRow + 1, lCol + 1, rRow - 1, rCol - 1);
            }
            else
            {
                if (lCol <= rCol)
                {
                    result.Add(array[lRow][lCol]);
                }
            }
        }
        
        public static int[] SnailByAmosCardino(int[][] grid)
        {
            var result = new List<int>();

            if (!grid.SelectMany(row => row).Any())
                return result.ToArray();

            // First row
            result.AddRange(grid.First());

            // Far right column
            result.AddRange(grid.Skip(1).Select(row => row.Last()));

            // Bottom row
            result.AddRange(grid.Last().Reverse().Skip(1));

            // Far left column
            result.AddRange(grid.Skip(1).SkipLast(1).Select(row => row.First()).Reverse());

            // Trim and recurse
            var newGrid = grid
                .Skip(1)
                .SkipLast(1)
                .Select(row => row
                    .Skip(1)
                    .SkipLast(1)
                    .ToArray())
                .ToArray();

            result.AddRange(Snail(newGrid));

            return result.ToArray();
        }
        
        public static int[] SnailByWei(int[][] array)
        {
            if (array.Length == 0 ) { return new int[0]; }
            if (array.Length == 1 ) { return array[0]; }
            var n = array.Length;
            var res = new int[n * n];
            for (int i = 0, x = -1, y = 0, edge = 0; ;) {
                while (x < n - edge - 1) { res[i++] = array[y][++x]; }
                if (i >= res.Length - 1) { break; }
                while (y < n - edge - 1) { res[i++] = array[++y][x]; }
                while (x > edge) { res[i++] = array[y][--x]; }
                if (i >= res.Length - 1) { break; }
                ++edge;
                while (y > edge) { res[i++] = array[--y][x]; }
            }
            return res;
        }
        
        public static int[] SnailByAwesson(int[][] array)
        {
            int l = array[0].Length;
            int[] sorted = new int[l * l];
            Snail(array, -1, 0, 1, 0, l, 0, sorted);
            return sorted;
        }

        private static void Snail(int[][] array, int x, int y, int dx, int dy, int l, int i, int[] sorted)
        {
            if (l == 0)
                return;
            for (int j = 0; j < l; j++)
            {
                x += dx;
                y += dy;
                sorted[i++] = array[y][x];
            }
            Snail(array, x, y, -dy, dx, dy == 0 ? l - 1 : l, i, sorted);
        }
    }
}