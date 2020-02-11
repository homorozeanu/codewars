using BenchmarkDotNet.Attributes;

namespace SnailSort.Benchmarks
{
    [MemoryDiagnoser]
    [RankColumn]
    public class SnailSolutionBenchmarks
    {
        private readonly int[][] array =
        {
            new[] {1, 2, 3, 1},
            new[] {4, 5, 6, 4},
            new[] {7, 8, 9, 7},
            new[] {7, 8, 9, 7}
        };

        [Benchmark(Baseline = true)]
        public void SnailByIterations()
        {
            SnailSolution.Snail(array);
        }

        [Benchmark]
        public void SnailByAmosCardino()
        {
            SnailSolution.SnailByAmosCardino(this.array);
        }

        [Benchmark]
        public void SnailByWei()
        {
            SnailSolution.SnailByWei(this.array);
        }

        [Benchmark]
        public void SnailByAwesson()
        {
            SnailSolution.SnailByAwesson(this.array);
        }
    }
}