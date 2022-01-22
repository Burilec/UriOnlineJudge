using BenchmarkDotNet.Attributes;
using System;
using System.Linq;

namespace Uri1026.Bench
{
    public sealed class Uri1026Benchmark
    {
        private readonly string _data;

        public Uri1026Benchmark()
        {
            var random = new Random(42);
            var first = random.Next();
            var second = random.Next();

            _data = $"{first} {second}";
        }

        [Benchmark]
        public void First()
        {
            var enumerable = _data.Split(' ').Select(long.Parse).ToList();
            var _ = enumerable.First() ^ enumerable.Last();
        }

        [Benchmark]
        public void Second()
        {
            var convertAll = Array.ConvertAll(_data.Split(' '), long.Parse);
            var _ = convertAll[0] ^ convertAll[^1];
        }

        [Benchmark]
        public void Third()
        {
            var strings = _data.Split(' ');

            var _ = long.Parse(strings[0]) ^ long.Parse(strings[1]);
        }
    }
}