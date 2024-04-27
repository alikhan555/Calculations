using System.Reflection;
using Xunit.Sdk;

namespace Calculations.Test.DataShare.DataAttributes
{
    public class IsEvenDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { new IsEvenTestDataModel() { Input = 1, Result = false } };
            yield return new object[] { new IsEvenTestDataModel() { Input = 2, Result = true } };
            yield return new object[] { new IsEvenTestDataModel() { Input = 3, Result = false } };
            yield return new object[] { new IsEvenTestDataModel() { Input = 4, Result = true } };
            yield return new object[] { new IsEvenTestDataModel() { Input = 5, Result = false } };
            yield return new object[] { new IsEvenTestDataModel() { Input = 6, Result = true } };
            yield return new object[] { new IsEvenTestDataModel() { Input = 7, Result = false } };
            yield return new object[] { new IsEvenTestDataModel() { Input = 8, Result = true } };
            yield return new object[] { new IsEvenTestDataModel() { Input = 9, Result = false } };
            yield return new object[] { new IsEvenTestDataModel() { Input = 10, Result = true } };
        }
    }
}