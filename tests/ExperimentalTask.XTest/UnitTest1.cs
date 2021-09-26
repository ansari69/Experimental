using ExperimentalTask.Infrastructure;
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
        
        
        //[Fact]
        //[Theory]
        //[InlineData("1+1","2")]
        //[InlineData("3+3","6")]
        //[InlineData("4+4","8")]
        //public void Test1(string request , string result)
        //{
        //    TestInput testInput = new TestInput();

        //   var r = testInput.FuncCalculation(request);

        //    Assert.IsType<string>(result);
        //    Assert.Equal(result, r); 

        //}



        [Theory]
        [MemberData(nameof(DataForTest1.GetData1), MemberType = typeof(DataForTest1))]
        public void Test2(string request, string result)
        {
            TestInput testInput = new TestInput();

            var r = testInput.FuncCalculation(request);

            Assert.IsType<string>(result);
            Assert.Equal(result, r);

        }


        //[Theory(Skip = "eeeeeee")]
        [Theory]
        [Trait("ui","cc")]
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
