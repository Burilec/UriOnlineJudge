using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Linq;

namespace Uri1026.Bench
{
    public sealed class Md5VsSha256
    {
        private readonly string _data;

        public Md5VsSha256()
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
            var _ = enumerable[0] ^ enumerable.Last();
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

            var a = long.Parse(strings[0]);

            var b = long.Parse(strings[1]);

            var _ = a ^ b;
        }
    }


    internal static class Program
    {
        private static void Main()
        {
            var _ = BenchmarkRunner.Run<Md5VsSha256>();
        }
    }
}
