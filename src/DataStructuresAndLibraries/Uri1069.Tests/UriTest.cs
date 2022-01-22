using DefaultTest;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace Uri1069.Tests
{
    public sealed class UriTest
    {
        [Theory]
        [InlineData("testInput1.txt", "testResult1.txt")]
        [InlineData("testInput2.txt", "testResult2.txt")]
        [InlineData("testInput3.txt", "testResult3.txt")]
        [InlineData("testInput4.txt", "testResult4.txt")]
        [InlineData("testInput5.txt", "testResult5.txt")]
        [InlineData("testInput6.txt", "testResult6.txt")]
        public async Task Test(string fileNameInput, string fileNameResult)
        {
            var input = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "Input", fileNameInput);

            var outPut = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "Result", fileNameResult);

            Assert.True(await Default.Test(input, outPut, Uri.Main));
        }
    }
}
