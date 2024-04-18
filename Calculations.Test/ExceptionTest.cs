using Xunit;

namespace Calculations.Test
{
    public class ExceptionTest
    {
        [Fact]
        public void Exception_ThrowArgumentNullException_Hello()
        {
            MyExceptions myExceptions = new MyExceptions();
            var exceptionResult = Assert.Throws<ArgumentException>(() => myExceptions.ThrowArgumentNullException(null));
            Assert.Equal("hello", exceptionResult.Message);
        }
    }
}
