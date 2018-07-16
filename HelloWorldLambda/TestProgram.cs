using Amazon.Lambda.TestUtilities;
using NUnit.Framework;

namespace HelloWorldLambda
{
    [TestFixture]
    class TestProgram
    {
        [Test]
        public void TestToUpperFunction()
        {
            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Program();
            var context = new TestLambdaContext();
            var upperCase = function.Handle("hello world", context);
            Assert.AreEqual("hello world", upperCase);
        }
    }
}
