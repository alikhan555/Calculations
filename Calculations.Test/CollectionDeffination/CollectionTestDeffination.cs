using Calculations.Test.Fixtures;
using Xunit;

namespace Calculations.Test.CollectionDeffination
{
    [CollectionDefinition("Collection")]
    public class CollectionTestDeffination : IClassFixture<CollectionFixture>
    {
    }
}
