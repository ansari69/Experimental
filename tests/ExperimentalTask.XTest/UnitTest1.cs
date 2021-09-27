using ExperimentalTask.Infrastructure;
using Moq;
using System;
using Xunit;
using Xunit.Abstractions;

namespace ExperimentalTask.XTest
{
    public class UnitTest1
    {

        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }


        
        [Theory]
        [InlineData("1+1+5-2", "5")]
        [InlineData("3+3+4*2+1", "15")]
        [InlineData("4+4/2", "6")]
        public void Test1(string request, string result)
        {
            TestInput testInput = new TestInput();

            var r = testInput.FuncCalculation(request);

            Assert.IsType<string>(result);
            Assert.Equal(result, r);

        }



        [Theory]
        [MemberData(nameof(DataForTest.GetData1), MemberType = typeof(DataForTest))]
        public void Test2(string request, string result)
        {
            TestInput testInput = new TestInput();

            var r = testInput.FuncCalculation(request);

            Assert.IsType<string>(result);
            Assert.Equal(result, r);

        }


        //[Theory(Skip = "eeeeeee")]
        [Theory]
        [Trait("category","one")]
        [ClassData(typeof(MemberClassData))]
        public void Test3(string request, string result)
        {
            TestInput testInput = new TestInput();

            var r = testInput.FuncCalculation(request);

            _testOutputHelper.WriteLine("Output : ");
            _testOutputHelper.WriteLine(request + "  --  " + result);

            Assert.IsType<string>(result);
            Assert.Equal(result, r);

        }




    }
}
