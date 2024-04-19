using Xunit;

namespace Calculations.Test
{
    public class CollectionTest
    {
        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_NotHaveZero()
        {
            Assert.All(Collections.Fibonacci, x => Assert.NotEqual(0, x));
        }

        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_MustHave5()
        {
            Assert.Contains(5, Collections.Fibonacci);
        }

        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_MustNotHave4()
        {
            Assert.DoesNotContain(4, Collections.Fibonacci);
        }

        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_ExpectedCollection()
        {
            List<int> expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21 };
            Assert.Equal(expectedCollection, Collections.Fibonacci);
        }
    }
}
