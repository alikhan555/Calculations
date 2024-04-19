using Xunit;

namespace Calculations.Test
{
    public class CollectionFixture
    {
        public Collections CollectionsInstance = new Collections();
    }

    public class CollectionTest : IClassFixture<CollectionFixture>
    {
        private CollectionFixture _collectionFixture;

        public CollectionTest(CollectionFixture collectionFixture)
        {
            _collectionFixture = collectionFixture;
        }

        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_NotHaveZero()
        {
            Collections collections = _collectionFixture.CollectionsInstance;
            Assert.All(collections.Fibonacci, x => Assert.NotEqual(0, x));
        }

        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_MustHave5()
        {
            Collections collections = _collectionFixture.CollectionsInstance;
            Assert.Contains(5, collections.Fibonacci);
        }

        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_MustNotHave4()
        {
            Collections collections = _collectionFixture.CollectionsInstance;
            Assert.DoesNotContain(4, collections.Fibonacci);
        }

        [Fact]
        [Trait("Categories", "Fibo")]
        public void Fibonacci_ExpectedCollection()
        {
            Collections collections = _collectionFixture.CollectionsInstance;
            List<int> expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21 };
            Assert.Equal(expectedCollection, collections.Fibonacci);
        }
    }
}
