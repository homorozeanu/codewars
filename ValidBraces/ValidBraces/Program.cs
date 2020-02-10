using System;
using BenchmarkDotNet.Running;

namespace ValidBraces
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ValidBracesBenchmarks>();
        }
    }
}