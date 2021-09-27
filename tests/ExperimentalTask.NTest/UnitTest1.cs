using ExperimentalTask.Infrastructure;
using NUnit.Framework;

namespace ExperimentalTask.NTest
{
   // [TestFixture]
    public class Tests
    {

        private TestInput testInput;

        [SetUp]
        public void Setup()
        {
            testInput = new TestInput();
        }


       // [Fact]
        [Theory]
        [TestCase("6+7*2", "20")]
        [TestCase("2+2+2*5/2", "9")]
        [TestCase("4*4*2/8", "4")]
        public void Test1(string request, string result)
        {
          //  TestInput testInput = new TestInput();

            var resultValue = testInput.FuncCalculation(request);

            Assert.AreEqual(result, resultValue);
        }



        [TestCaseSource(typeof(MemberClassData))]
        [Category("zarb")]
        public void Test2(string request, string result)
        {

            var resultValue = testInput.FuncCalculation(request);
            Assert.AreEqual(result, resultValue);

            // Assert.Pass();
            //Assert.Fail();
        }



        #region Last code

        ////[Test]
        ////public void Test3()
        ////{
        ////   // TestInput testInput = new TestInput();
        ////    var resultValue = testInput.FuncCalculation("2+3*2-6");
        ////    Assert.AreEqual("2", resultValue);
        ////   // Assert.Pass();
        ////}



        ////[Test]
        ////[Category("sum")]
        ////[Ignore("off")]
        ////public void Test4()
        ////{
        ////    var result = testInput.FuncCalculation("8+2*50");

        ////    Assert.That(result, Is.EqualTo("108"));
        ////   // Assert.Pass();
        ////    //Assert.Fail();
        ////}


        #endregion
    }
}