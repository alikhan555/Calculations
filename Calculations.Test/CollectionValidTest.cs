using Calculations.Test.Fixtures;
using Xunit;

namespace Calculations.Test
{
    [Collection("Collection")]
    public class CollectionValidTest : IClassFixture<CollectionFixture>
    {
        private CollectionFixture _collectionFixture;

        public CollectionValidTest(CollectionFixture collectionFixture)
        {
            _collectionFixture = collectionFixture;
        }

        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_NotHaveZero()
        {
            Thread.Sleep(3000);

            Collections collections = _collectionFixture.CollectionsInstance;
            Assert.All(collections.Fibonacci, x => Assert.NotEqual(0, x));
        }

        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_MustHave5()
        {
            Thread.Sleep(3000);

            Collections collections = _collectionFixture.CollectionsInstance;
            Assert.Contains(5, collections.Fibonacci);
        }
    }
}
