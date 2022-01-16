using DefaultTest;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace Uri1026.Tests
{
    public sealed class UriTest
    {
        [Theory]
        [InlineData("testInput1.txt", "testResult1.txt")]
        public async Task Test(string fileNameInput, string fileNameResult)
        {
            var input = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "Input", fileNameInput);

            var outPut = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "Result", fileNameResult);

            Assert.True(await Default.Test(input, outPut, Uri.Main));
        }
    }
}
