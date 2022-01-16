using System;
using System.IO;
using System.Threading.Tasks;

namespace DefaultTest
{
    public static class Default
    {
        public static async Task<bool> Test(string pathInput, string pathOutput, Action action)
        {
            using var streamReaderInput = new StreamReader(pathInput);

            await using var stringWriter = new StringWriter();

            using var stringReader = new StringReader(await streamReaderInput.ReadToEndAsync());

            Console.SetIn(stringReader);

            Console.SetOut(stringWriter);

            action.Invoke();

            using var streamReaderResult = new StreamReader(pathOutput);

            var expected = await streamReaderResult.ReadToEndAsync();
            var result = stringWriter.ToString();

            return string.Equals(expected, result);
        }
    }
}