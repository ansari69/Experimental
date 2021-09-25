using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalTask.Domain.Entities
{
   public class Experimental
    {

        public Experimental()
        {

        }


        public string ExperimentalId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
 

    }
}
