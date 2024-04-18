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
    }
}
