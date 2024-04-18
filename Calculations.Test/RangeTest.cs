using Xunit;

namespace Calculations.Test
{
    public class RangeTest
    {
        [Fact]
        public void Range_MustBetween8To50()
        {
            Assert.InRange(Ranges.Age, 8, 50);
        }

        [Fact]
        public void Range_ProbablityMustBeGreaterThan80Percent()
        {
            Assert.NotInRange(Ranges.Probablity, 0, 0.800);
        }

        [Fact]
        public void Range_PhoneNoMustBeIn10To15Digits()
        {
            Assert.InRange(Ranges.PhoneNo.Length, 10, 15);
        }
    }
}
