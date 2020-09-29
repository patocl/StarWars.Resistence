using BenchmarkDotNet.Running;

namespace StarWars.Resistance.Benchmarks
{
    public class Program
    {
        public static void Main()
        {
            _ = BenchmarkRunner.Run(
                    new[]
                    {
                        BenchmarkConverter.TypeToBenchmarks( typeof(Solutions)),
                        BenchmarkConverter.TypeToBenchmarks( typeof(SolutionsWithRandom))
                    }
                );
        }
    }
}
