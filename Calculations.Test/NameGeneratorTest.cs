using Xunit;

namespace Calculations.Test
{
    public class NameGeneratorTest
    {
        [Fact]
        public void MakeFullNameTest_Equal()
        {
            NameGenerator nameGenerator = new NameGenerator();
            string result = nameGenerator.MakeFullName("Muhammad", "Ali");

            Assert.Equal("muhammad Ali", result, ignoreCase: true);
        }

        [Fact]
        public void MakeFullNameTest_Contains()
        {
            NameGenerator nameGenerator = new NameGenerator();
            string result = nameGenerator.MakeFullName("Muhammad", "Ali");

            Assert.Contains("muhammad", result, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void MakeFullNameTest_StartWith()
        {
            NameGenerator nameGenerator = new NameGenerator();
            string result = nameGenerator.MakeFullName("Muhammad", "Ali");

            Assert.StartsWith("muhammad", result, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void MakeFullNameTest_EndsWith()
        {
            NameGenerator nameGenerator = new NameGenerator();
            string result = nameGenerator.MakeFullName("Muhammad", "Ali");

            Assert.EndsWith("ali", result, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void MakeFullNameTest_Match()
        {
            NameGenerator nameGenerator = new NameGenerator();
            string result = nameGenerator.MakeFullName("MUhammad", "Ali");

            Assert.Matches("[A-Z]{2}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void MakeFullNameTest_MustHaveAValue()
        {
            NameGenerator.NickName = null;
            Assert.Null(NameGenerator.NickName);
        }

        [Fact]
        public void MakeFullNameTest_MustTrue()
        {
            Assert.True(string.IsNullOrWhiteSpace(NameGenerator.NickName));
        }
    }
}
