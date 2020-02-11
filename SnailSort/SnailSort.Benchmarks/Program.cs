using BenchmarkDotNet.Running;

namespace SnailSort.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SnailSolutionBenchmarks>();
        }
    }
}