using BenchmarkDotNet.Running;

namespace DictionaryMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DictionaryMergerBenchmarks>();
        }
    }
}