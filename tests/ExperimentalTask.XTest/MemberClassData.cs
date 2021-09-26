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


            yield return new object[] { "1+1", "2" };
            yield return new object[] { "2+1", "3" };
            yield return new object[] { "4+1", "5" };
            // throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumerator();
           // throw new NotImplementedException();
        }
    }
}
