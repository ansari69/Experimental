using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalTask.XTest
{
   public static class DataForTest1
    {

        public static List<object[]> GetData1()
        {

            List<object[]> aa = new List<object[]>();

            aa.Add(new object[] { "1+1", "2" });
            aa.Add(new object[] { "2+2", "4" });
            aa.Add(new object[] { "3+3", "6" });
            aa.Add(new object[] { "4+4", "8" });


            return aa;
        }


    }
}
