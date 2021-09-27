using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalTask.XTest
{
   public static class DataForTest
    {

        public static List<object[]> GetData1()
        {

            List<object[]> list = new List<object[]>();

            list.Add(new object[] { "5*5+10", "35" });
            list.Add(new object[] { "8*2+4", "20" });
            list.Add(new object[] { "3+3*2", "9" });
            list.Add(new object[] { "7*2/2", "7" });


            return list;
        }


    }
}
