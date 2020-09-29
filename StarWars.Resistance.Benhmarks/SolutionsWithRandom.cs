using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace StarWars.Resistance.Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MarkdownExporter]
    [MarkdownExporterAttribute.GitHub]
    [CategoriesColumn]
    [RankColumn]
    [SimpleJob(launchCount: 1, warmupCount: 1, targetCount: 1)]
    public class SolutionsWithRandom
    {

        public static int[] GenerateRandomArray()
        {
            const int min = 0;
            const int max = 1_000_000_000;
            const int n = 400_000;

            var randNum = new Random();
            return Enumerable
                .Repeat(0, n)
                .Select(i => randNum.Next(min, max))
                .ToArray();
        }

        public int[] Array => GenerateRandomArray();

        [Benchmark(Baseline = true)]
        [BenchmarkCategory("R2D2-Random")]
        public void Solution1()
        {
            _ = Resistance.Solution1.Solution(Array);
        }

        [Benchmark]
        [BenchmarkCategory("C3PO-Random")]
        public void Solution2()
        {
            _ = Resistance.Solution2.Solution(Array);
        }

        [Benchmark]
        [BenchmarkCategory("BB8-Random")]
        public void Solution3()
        {
            _ = Resistance.Solution3.Solution(Array);
        }
    }
}
