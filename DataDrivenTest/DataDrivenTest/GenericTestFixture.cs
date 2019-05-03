using NUnit.Framework;

namespace DataDrivenTest
{
    [TestFixture(typeof(int))]
    [TestFixture(typeof(string))]

   public class GenericTestFixture<T>
    {
        [Test]
        public void TestType()
        {
            Assert.Pass($"Te generic test type is {typeof(T)}");
        }

    }
}
