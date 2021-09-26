using ExperimentalTask.Infrastructure;
using NUnit.Framework;

namespace ExperimentalTask.NTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }





       // [Fact]
        [Theory]
        [TestCase("3+3", "6")]
        [TestCase("4+4", "8")]
        [TestCase("-4+4", "Incorrect string")]
        public void Test4(string request, string result)
        {
            TestInput testInput = new TestInput();

            var resultValue = testInput.FuncCalculation(request);

            Assert.AreEqual(result, resultValue);

        }


        [Test]
        public void Test1()
        {



          //  Assert.Pass();
        }
    }
}