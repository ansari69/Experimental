using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalTask.NTest
{
    public class MemberClassData : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { "1+1", "2" };
            yield return new object[] { "2+1", "3" };
            yield return new object[] { "4+1", "5" };

            // throw new NotImplementedException();
        }
    }
}
