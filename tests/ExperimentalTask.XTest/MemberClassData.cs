using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalTask.XTest
{
    public class MemberClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "3+1+5", "9" };
            yield return new object[] { "5+5-2", "8" };
            yield return new object[] { "4+1*6", "10" };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        public IEnumerator<object> moqData()
        {
            yield return new object[] { };
        }

    }
}
