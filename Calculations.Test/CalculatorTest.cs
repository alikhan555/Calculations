using Xunit;

namespace Calculations.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_GivenTwoIntValues_ReturnInt()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnDouble()
        {
            Calculator calculator = new Calculator();
            double result = calculator.AddDouble(2.55, 3.22);

            Assert.Equal(6, result, 0);
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(5, false)]
        [InlineData(6, true)]
        [InlineData(7, false)]
        [InlineData(8, true)]
        [InlineData(9, false)]
        [InlineData(10, true)]
        public void IsEven_TestOddAndEven(int n, bool expected)
        {
            Calculator calculator = new Calculator();
            bool result = calculator.IsEven(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(CalculationDataShare.IsEvenData), MemberType = typeof(CalculationDataShare))]
        public void IsEven_TestOddAndEven_WithMemberData(int n, bool expected)
        {
            Calculator calculator = new Calculator();
            bool result = calculator.IsEven(n);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(CalculationDataShare.IsEvenTestDataModels), MemberType = typeof(CalculationDataShare))]
        public void IsEven_TestOddAndEven_WithMemberDataModel(IsEvenTestDataModel dataModels)
        {
            Calculator calculator = new Calculator();
            bool result = calculator.IsEven(dataModels.Input);
            Assert.Equal(dataModels.Result, result);
        }
    }
}
