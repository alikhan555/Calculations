using Calculations.Test.Fixtures;
using Xunit;

namespace Calculations.Test
{
    [Collection("Collection")]
    public class CollectionInvalidTest
    {
        private CollectionFixture _collectionFixture;

        public CollectionInvalidTest(CollectionFixture collectionFixture)
        {
            _collectionFixture = collectionFixture;
        }

        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_MustNotHave4()
        {
            Thread.Sleep(3000);

            Collections collections = _collectionFixture.CollectionsInstance;
            Assert.DoesNotContain(4, collections.Fibonacci);
        }

        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_ExpectedCollection()
        {
            Thread.Sleep(3000);

            Collections collections = _collectionFixture.CollectionsInstance;
            List<int> expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21 };
            Assert.Equal(expectedCollection, collections.Fibonacci);
        }
    }
}
