using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using System.Collections.Generic;

namespace Pluralize.NET.Performance
{
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    [MarkdownExporterAttribute.GitHub]
    public class PluralizeOldVsNew
    {
        private readonly Faster.Pluralizer newPluralizer = new Faster.Pluralizer();
        private readonly Pluralizer pluralizer = new Pluralizer();

        private IEnumerable<string> terms = new[]
        {
            "hi",
            "car",
            "dog",
            "bird",
            "hippo",
            "ho",
            "nose",
            "cactus",
            "I",
            "me"
        };

        [Benchmark]
        public void PluralizeTerms()
        {
            foreach (var term in terms)
            {
                pluralizer.Pluralize(term);
            }
        }

        [Benchmark]
        public void PluralizeTermsFaster()
        {
            foreach (var term in terms)
            {
                newPluralizer.Pluralize(term);
            }
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<PluralizeOldVsNew>();
        }
    }
}
