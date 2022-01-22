using BenchmarkDotNet.Running;

namespace Uri1026.Bench
{
    internal static class Program
    {
        private static void Main()
        {
            var _ = BenchmarkRunner.Run<Uri1026Benchmark>();
        }
    }
}
