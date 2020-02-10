using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace ValidBraces
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class ValidBracesBenchmarks
    {
        private const string braces = "(({{[[]]}}))";
        private readonly ValidBraces sut = new ValidBraces(); 

        [Benchmark(Baseline = true)]
        public void ValidBracesWithStack()
        {
            this.sut.ValidBracesWithStack(braces);
        }       
        
        [Benchmark]
        public void ValidBracesWithStringReplace()
        {
            this.sut.ValidBracesWithStringReplace(braces);
        }
    }
}